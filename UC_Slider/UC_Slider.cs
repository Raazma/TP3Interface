using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Slider
{
    public partial class UC_Slider : UserControl
    {
        public UC_Slider()
        {
            Init();
            InitializeComponent();
            
        }
        #region "private members"
        // Image de la bande désactivée
        private Image m_Bar_Disable;
        // image de la bande activée
        private Image m_Bar_Enable;
        // Image du curseur désactivé
        private Image m_Cursor_Disable;
        // Image du curseur activé
        private Image m_Cursor_Enable;
        // Image du curseur en déplacement
        private Image m_Cursor_Over;
        // Indicateur d'activation du contrôle
        private bool m_enabled = false;
        // Indicateur de déplacement du curseur
        private bool m_changing_position = false;
        // Marges horizontale qui tient compte de la largeur du curseur
        private int m_hor_margin;
        // largeur du curseur
        private int m_cursor_height;
        // Position actuelle du curseur
        private int m_hor_position;
        // Rectangle englobant la bande
        private Rectangle m_bar_frame;
        // Valeur mininale désignée par le contrôle
        private int m_minimum;
        // Valeur maximale désignée par le contrôle
        private int m_maximum;
        // Valeur désignée par le contrôle
        private int m_value;
        // Object utilitaire de traçage hors écran afin d'optimiser l'affichage
        private BitmapUtilities.OffScreenBitmap m_OSB;
        #endregion

        #region "Settings"
        ///////////////////////////////////////////////////////////////////////
        // I n i t
        ///////////////////////////////////////////////////////////////////////
        // Cette méthode initialise les valeurs par défaut du contrôle
        ///////////////////////////////////////////////////////////////////////
        private void Init()
        {
            // Étendue par défaut de la valeur désignée par le contrôle
            m_minimum = -100;
            m_maximum = 100;
            // Valeur initiale désignée par le contrôle
            m_value = 0;
            // Récupération des images qui constituent le contrôle à partir du
            // fichier de ressources ImagesRessource
            BarDisableImage = ImageResource.Vertical_Bar_Enable;
            BarEnableImage = ImageResource.Vertical_Bar_Enable;
            CursorDisableImage = ImageResource.Cursor_Disable;
            CursorEnableImage = ImageResource.Cursor_Enable;
            CursorOverImage = ImageResource.Cursor_Over;
            // Ajout du délégate de l'événement MouseWheel
            this.MouseWheel += new MouseEventHandler(UC_Slider_MouseWheel);
            // Mise à jour de la topologie du contrôle
            UpdateSlider();
        }
        ///////////////////////////////////////////////////////////////////////
        // B u i l d _ O f f _ S c r e e n _ B i t m a p
        ///////////////////////////////////////////////////////////////////////
        // Cette méthode initialise l'objet utilitaire de traçage hors écran
        ///////////////////////////////////////////////////////////////////////
        private void Build_Off_Screen_Bitmap()
        {
            // Création de l'objet avec le contexte de périphérique du contrôle
            m_OSB = new BitmapUtilities.OffScreenBitmap(this.CreateGraphics());
            // Assignation de la couleur de fond avec celle du contrôle
            m_OSB.BackColor = this.BackColor;
            // Réglage de l'affichage en mode haute qualité
            m_OSB.Smoothing_Mode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        ///////////////////////////////////////////////////////////////////////
        // U p d a t e S l i d e r
        ///////////////////////////////////////////////////////////////////////
        // Cette méthode met à jour la topologie du contrôle
        ///////////////////////////////////////////////////////////////////////
        private void UpdateSlider()
        {
            // Calcul du rectangle qui englobe la bande
            m_bar_frame = new Rectangle(new Point(0, 0 ),
            new Size(this.Width, this.Height));
            // Déterminer la largeur du curseur
            m_cursor_height = m_Cursor_Disable.Height;
            // calcul de la marge à partir de la largeur du curseur
            m_hor_margin = m_cursor_height / 2;
            // Calcul de la position actuelle du curseur
            m_hor_position = ValueToPosition();
            // Initialise l'objet utilitaire de traçage hors écran
            Build_Off_Screen_Bitmap();
        }
        ///////////////////////////////////////////////////////////////////////
        // V a l u e T o P o s i t i o n
        ///////////////////////////////////////////////////////////////////////
        // Cette fonction retourne la position en fonction de la valeur
        // représentée par le contrôle
        ///////////////////////////////////////////////////////////////////////
        private int ValueToPosition()
        {
            // Calcul de l'étendue de la position du curseur
            decimal position_range = this.Height - 2 * m_hor_margin;
            // Calcul de l'étendue de la valeur du contrôle
            decimal value_range = m_maximum - m_minimum;
            // Calcul de rapport proportionnel entre les deux étendues
            decimal range_ratio = position_range / value_range;
            // Calcul de la position en fonction de la valeur du contrôle
            m_hor_position = (int)Math.Round((m_value - m_minimum) * range_ratio) + m_hor_margin;
            // Retourner la position
            return m_hor_position;
        }
        ///////////////////////////////////////////////////////////////////////
        // P o s i t i o n T o V a l u e
        ///////////////////////////////////////////////////////////////////////
        // Cette fonction retourne la valeur en fonction de la
        // position du curseur
        ///////////////////////////////////////////////////////////////////////
        private int PositionToValue()
        {
            // Calcul de l'étendue de la position du curseur
            decimal position_range = this.Height - 2 * m_cursor_height;
            // Calcul de l'étendue de la valeur du contrôle
            decimal value_range = m_maximum - m_minimum;
            // Calcul de rapport proportionnel entre les deux étendues
            decimal range_ratio = value_range / position_range;
            // Calcul de la valeur du contrôle en fonction de la position du curseur
            m_value = ValidatedValue((int)Math.Round((m_hor_position - m_cursor_height) * range_ratio + m_minimum));
            // Retourner la valeur
            return m_value;
        }

        ///////////////////////////////////////////////////////////////////////
        // P o s i t i o n T o C u r s o r F r a m e
        ///////////////////////////////////////////////////////////////////////
        // Cette fonction retourne le rectangle de position et de taille
        // pour le traçage du curseur à la position déduite par la valeur
        // du contrôle
        ///////////////////////////////////////////////////////////////////////
        private Rectangle PositionToCursorFrame()
        {
            // calcul de la position du curseur à partir de la valeur
            // du contrôle. Remarquez que l'on tient compte de la
            // largeur du du curseur
            Point position = new Point(0 , ValueToPosition() - (m_cursor_height / 2));
            // Calcul de la taille du curseur en fonction des dimensions de
            // dimensions de son image
            Size cursorSize = new Size(this.Width, m_Cursor_Disable.Size.Height);
            // retourner le rectangle
            return new Rectangle(position, cursorSize);
        }
        ///////////////////////////////////////////////////////////////////////
        // V a l i d a t e d V a l u e
        ///////////////////////////////////////////////////////////////////////
        // Cette fonction retourne la valeur value passée en paramètre en
        // s'assurant qu'elle n'excède pas l'étendue prescrite par
        // m_minimum et m_maximum
        ///////////////////////////////////////////////////////////////////////
        private int ValidatedValue(int value)
        {
            if (value < m_minimum)
                value = m_minimum;
            if (value > m_maximum)
                value = m_maximum;
            return value;
        }
        #endregion

        #region "Drawing"
        ///////////////////////////////////////////////////////////////////////
        // D r a w
        ///////////////////////////////////////////////////////////////////////
        // Cette méthode trace le contrôle hors écran en passant par l'objet
        // m_OSB et ensuite copie sa bitmap dans son panel
        ///////////////////////////////////////////////////////////////////////
        private void Draw(Graphics DC)
        {
            // Si l'objet de traçage hors écran m_OSB est instancié
            if (m_OSB != null)
            {
                // Effacer le contenu de la bitmap mémoire
                m_OSB.Clear();
                if (m_enabled)
                {// le contrôle est actif
                    //(survolé par le pointeur de la souris)
                    // Si l'image de la bande version active est présente
                    if (m_Bar_Enable != null)
                        // tracer dans la bitmap mémoire la bande version active
                        m_OSB.DC.DrawImage(m_Bar_Enable, m_bar_frame);
                    // si le curseur est en train de se faire déplacer
                    if (m_changing_position)
                    {
                        // Si l'image du curseur version déplacé est présente
                        if (m_Cursor_Over != null)
                            // tracer dans la bitmap mémoire le curseur version déplacé
                            m_OSB.DC.DrawImage(m_Cursor_Over, PositionToCursorFrame());
                    }
                    else
                    {
                        // Si l'image du curseur version actif est présente
                        if (m_Cursor_Enable != null)
                            // tracer dans la bitmap mémoire le curseur version actif
                            m_OSB.DC.DrawImage(m_Cursor_Enable, PositionToCursorFrame());
                    }
                }
                else
                {// le contrôle est inactif
                    // (n'est pas survolé par le pointeur de la souris)
                    // Si l'image de la bande version inactive est présente
                    if (m_Bar_Disable != null)
                        // tracer dans la bitmap mémoire la bande version inactive
                        m_OSB.DC.DrawImage(m_Bar_Disable, m_bar_frame);
                    // Si l'image du curseur version inactif est présente
                    if (m_Cursor_Disable != null)
                        // tracer dans la bitmap mémoire le curseur version inactif
                        m_OSB.DC.DrawImage(m_Cursor_Disable, PositionToCursorFrame());
                }
                // copier la bitmap mémoire dans le panel du contrôle
                m_OSB.Draw();
            }
        }
        #endregion

        #region "Public Properties"
        // la macro [Description(…)] permet d’informer l’utilisateur
        // du rôle de la propriétée
        [Description("Borne inférieure de la valeur")]
        public int Minimum
        {
            set { m_minimum = value; this.Refresh(); }
            get { return m_minimum; }
        }
        [Description("Borne supérieur de la valeur")]
        public int Maximum
        {
            set { m_maximum = value; this.Refresh(); }
            get { return m_maximum; }
        }
        [Description("Valeur actuelle du contrôle")]
        public int Value
        {
            set { m_value = ValidatedValue(value); this.Refresh(); OnValueChanged(); }
            get { return m_value; }
        }
        [Description("Image de la bande du contrôle lorsqu'il est inactif")]
        public Image BarDisableImage
        {
            set { m_Bar_Disable = value; this.Refresh(); }
            get { return m_Bar_Disable; }
        }
        [Description("Image de la bande du contrôle lorsqu'il est actif")]
        public Image BarEnableImage
        {
            set { m_Bar_Enable = value; this.Refresh(); }
            get { return m_Bar_Enable; }
        }
        [Description("Image du curseur du contrôle lorsqu'il est inactif")]
        public Image CursorDisableImage
        {
            set { m_Cursor_Disable = value; this.Refresh(); }
            get { return m_Cursor_Disable; }
        }
        [Description("Image du curseur du contrôle lorsqu'il est actif")]
        public Image CursorEnableImage
        {
            set { m_Cursor_Enable = value; this.Refresh(); }
            get { return m_Cursor_Enable; }
        }
        [Description("Image du curseur en déplacement")]
        public Image CursorOverImage
        {
            set { m_Cursor_Over = value; this.Refresh(); }
            get { return m_Cursor_Over; }
        }
        #endregion

        private void UC_Slider_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void UC_Slider_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void UC_Slider_SizeChanged(object sender, EventArgs e)
        {
            UpdateSlider();
            this.Refresh();
        }

        private void UC_Slider_BackColorChanged(object sender, EventArgs e)
        {
            if (m_OSB != null)
                m_OSB.BackColor = this.BackColor;
        }

        #region "Mouse Events"

        private void UC_Slider_MouseEnter(object sender, EventArgs e)
        {
            // Rendre le contrôle actif
            m_enabled = true;
            // Redessiner le contrôle
            this.Refresh();
        }
        private void UC_Slider_MouseLeave(object sender, EventArgs e)
        {
            // Rndre le contrôle inactif
            m_enabled = false;
            // Redessiner le contrôle
            this.Refresh();
        }
        private void UC_Slider_MouseDown(object sender, MouseEventArgs e)
        {
            // Déterminer si le pointeur se trouve sur le curseur
            // Si oui, indiquer qu'il est en train de se faire déplacer
            m_changing_position = (PositionToCursorFrame()).Contains(e.Location);
            // Cacher le pointeur de la souris pour amélioré l'ergonomie de déplacement
            // du curseur du contrôle
            if (m_changing_position)
                //Cursor.Hide();
            // Redessiner le contrôle
            this.Refresh();
        }
        private void UC_Slider_MouseMove(object sender, MouseEventArgs e)
        {
            // Si le curseur est en train de se faire déplacer
            // Cela implique que lors du MouseDown on a détecté
            // que le pointeur de la souris se trouvait sur le curseur
            // du contrôle
            if (m_changing_position)
            {
                // Conserver la position horizontale du pointeur de la souris
                m_hor_position = e.Location.Y;
                // Convertir la position en valeur
                PositionToValue();
                // Déclancher l'événement ValueChanged
                OnValueChanged();
                // Redessiner directement le contrôle
                // afin de diminuer l'effet de scintillement
                Draw(this.CreateGraphics());
            }
        }

        private void UC_Slider_MouseUp(object sender, MouseEventArgs e)
        {
            // Lors d'un MouseUp le bouton de la souris n'est plus enfoncé
            // donc le curseur du contrôle n'est plus en train de se faire
            // déplacer
            m_changing_position = false;
            // Refaire apparaitre le pointeur de la souris
            Cursor.Show();
            // Redessiner le contrôle
            this.Refresh();
        }

        private void UC_Slider_MouseWheel(Object sender, MouseEventArgs e)
        {
            // Si le contrôle est actif accepter les événements MouseWheel
            if (m_enabled)
            {
                // Incrémenter ou décrémenter la valeur selon e.Delta
                Value = Value - (m_maximum - m_minimum) / 50 * e.Delta / Math.Abs(e.Delta);
                // Redessiner directement le contrôle
                // afin de diminuer l'effet de scintillement
                Draw(this.CreateGraphics());
                // Déclancher l'événement ValueChanged
                OnValueChanged();
            }
        }

        #endregion

        #region "delegates"
        // Prototype du delegate du traitement de l'événement ValueChanged
        public delegate void ValueChangedHandler(Object sender, EventArgs e);
        // Membre public de type ValueChangedHandler
        public event ValueChangedHandler ValueChanged = null;
        // Méthode d'appel du gestionnaire de l'événement ValueChanged
        private void OnValueChanged()
        {
            // ce test est nécessaire car on ne peut assumer que l'utilisateur
            // aurait effectivement associé une méthode à cet événement
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }
        #endregion
    }
}
