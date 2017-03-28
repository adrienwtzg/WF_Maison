using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WF_Maison
{
    public partial class frmMain : Form
    {
        Maison maMaison = new Maison(200, 200, 200, 200);

        Stopwatch TimerLongueAppuie = new Stopwatch();

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true; //Evite le vascillement de l'image
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            maMaison.Paint(sender, e);
        }

        class Maison
        {
            #region Variables d'instances

            int largeur;
            int longeur;
            Graphics g;
            Point location;

            public Point Location
            {
                get { return location; }
                set { location = value; }
            }

            #endregion

            /// <summary>
            /// Constructeur
            /// </summary>
            /// <param name="x">Coordonnées X</param>
            /// <param name="y">Coordonnées Y</param>
            public Maison(int x, int y, int largeur, int longeur)
            {
                this.largeur = largeur;
                this.longeur = longeur;
                location = new Point(x, y);
            }

            public void Paint(object sender, PaintEventArgs e)
            {
                g = e.Graphics;
                DessineMaison(sender, e);
            }

            public void DessineMaison(object sender, PaintEventArgs e)
            {
                #region Maison

                Fenetre mesFenetres = new Fenetre(Location.X, Location.Y, largeur, longeur);
                Porte maPorte = new Porte(Location.X, Location.Y, largeur, longeur);

                //Toit
                Point CoinGauche = new Point(Location.X + 0, Location.Y + 0); //Coin gauche du toit
                Point CoinDroit = new Point(Location.X + 200, Location.Y + 0); //Coin droit du toit
                Point CoinHaut = new Point(Location.X + 100, Location.Y - 100); //Sommet du toit

                Point[] toit = { CoinGauche, CoinDroit, CoinHaut }; //Ensemble des points du toit

                g.DrawPolygon(Pens.Black, toit); //Dessine le toit

                //Mur
                Point murInitialLocation = new Point(Location.X + 0, Location.Y + 0); //Location initiale du mur
                Rectangle mur = new Rectangle(murInitialLocation, new Size(longeur, Convert.ToInt32(Convert.ToDouble(longeur) * 0.75))); //définit les dimensions du mur
                g.DrawRectangle(Pens.Black, mur); //Dessine le mur

                //Fenetre
                //Fenetre_Paint(Location.X + 20, Location.Y + 20);
                //Fenetre_Paint(Location.X + 140, Location.Y + 20);
                mesFenetres.Paint(sender, e);

                //Porte x2
                //Point porteInitialLocation = new Point(Location.X + 40, Location.Y + 110); //Location initiale de la porte
                //Rectangle porte = new Rectangle(porteInitialLocation, new Size(Convert.ToInt32(Convert.ToDouble(longeur) * 0.1), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2))); //définit les dimensions de la porte
                //g.DrawRectangle(Pens.Black, porte); //Dessine la porte

                //Point porte2InitialLocation = new Point(Location.X + 140, Location.Y + 110); //Location initiale de la porte
                //Rectangle porte2 = new Rectangle(porte2InitialLocation, new Size(Convert.ToInt32(Convert.ToDouble(longeur) * 0.1), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2))); //définit les dimensions de la porte
                //g.DrawRectangle(Pens.Black, porte2); //Dessine la porte
                maPorte.Paint(sender, e);
                
                

                #endregion
            }

            public void Fenetre_Paint(int x, int y)
            {
                //Fenêtre x2
                g.DrawRectangle(Pens.Black, x, y, Convert.ToInt32(Convert.ToDouble(longeur) * 0.2), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2)); //Dessine une fenêtre
            }

        }

        class Fenetre
        {
            #region Variables d'instances

            int largeur;
            int longeur;
            Graphics g;
            Point location;

            public Point Location
            {
                get { return location; }
                set { location = value; }
            } //Propriété

            #endregion

            /// <summary>
            /// Constructeur
            /// </summary>
            /// <param name="x">Coordonnées X</param>
            /// <param name="y">Coordonnées Y</param>
            public Fenetre(int x, int y, int largeur, int longeur)
            {
                this.largeur = largeur;
                this.longeur = longeur;
                location = new Point(x, y);
            }

            public void Paint(object sender, PaintEventArgs e)
            {
                g = e.Graphics;
                DessineFenetre();
            }

            public void DessineFenetre()
            {
                //Fenetre
                Fenetre_Paint(Location.X + 20, Location.Y + 20);
                Fenetre_Paint(Location.X + 140, Location.Y + 20);
            }

            public void Fenetre_Paint(int x, int y)
            {
                //Fenêtre x2
                g.DrawRectangle(Pens.Black, x, y, Convert.ToInt32(Convert.ToDouble(longeur) * 0.2), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2)); //Dessine une fenêtre
            }

        }

        class Porte
        {
            #region Variables d'instances

            int largeur;
            int longeur;
            Graphics g;
            Point location;

            public Point Location
            {
                get { return location; }
                set { location = value; }
            }

            #endregion

            /// <summary>
            /// Constructeur
            /// </summary>
            /// <param name="x">Coordonnées X</param>
            /// <param name="y">Coordonnées Y</param>
            public Porte(int x, int y, int largeur, int longeur)
            {
                this.largeur = largeur;
                this.longeur = longeur;
                location = new Point(x, y);
            }

            public void Paint(object sender, PaintEventArgs e)
            {
                g = e.Graphics;
                DessineMaison(sender, e);
            }

            public void DessineMaison(object sender, PaintEventArgs e)
            {
                #region Maison

                //Porte x2
                Point porteInitialLocation = new Point(Location.X + 40, Location.Y + 110); //Location initiale de la porte
                Rectangle porte = new Rectangle(porteInitialLocation, new Size(Convert.ToInt32(Convert.ToDouble(longeur) * 0.1), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2))); //définit les dimensions de la porte
                g.DrawRectangle(Pens.Black, porte); //Dessine la porte

                Point porte2InitialLocation = new Point(Location.X + 140, Location.Y + 110); //Location initiale de la porte
                Rectangle porte2 = new Rectangle(porte2InitialLocation, new Size(Convert.ToInt32(Convert.ToDouble(longeur) * 0.1), Convert.ToInt32(Convert.ToDouble(largeur) * 0.2))); //définit les dimensions de la porte
                g.DrawRectangle(Pens.Black, porte2); //Dessine la porte

                #endregion
            }

           
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TimerLongueAppuie.Start();
                while(e.Button != MouseButtons.Left)
                {

                }
                TimerLongueAppuie.Stop();
            }
            if (TimerLongueAppuie.ElapsedMilliseconds > 2000)
            {
                frmMain_MouseMove(sender, e);
            }
            

        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            maMaison.Location = e.Location;
            Invalidate();

        }
    }
}
