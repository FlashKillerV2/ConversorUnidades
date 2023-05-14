using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;//libreria usada para validar los textbox
using System.Runtime.InteropServices;//libreria usada para mover el form

namespace ConversorUnidades
{
    public partial class Form1 : Form
    {

        //se usa como atributos para el movimiento del form, referencia en el evento toolStrip1_MouseDown
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]  private extern static void SendMessage(System.IntPtr hWnd ,int wMsg, int wParam, int lParam);

        //se declaran los arrays necesarios para los combobox dependientes
        string[] arrayMagnitudes = { "Longitud", "Área", "Temperatura", "Volumen", "Tiempo", "Frecuencia", "Velocidad", "Masa", "Densidad", "Fuerza", "Presión", "Potencia", "Carga_eléctrica", "Flujo_magnético", "Intensidad_magnética" };
        string[] arrayLongitud = { "Kilometro", "Metro", "Centímetro", "Milla", "Yarda", "Pie","Pulgada" };
        string[] arrayÁrea = { "km²", "m²", "mi²", "yd²", "ft²", "in²", "Hectarea" };
        string[] arrayTemperatura = { "Celsius", "Kelvin", "Farenheit" };
        string[] arrayVolumen = { "Galon", "m3", "Litro", "Mililitro", "ft3", "in3", "Onza" };
        string[] arrayTiempo = { "Siglo", "Decada", "Año", "Mes", "Semana", "Dia", "Hora", "Minuto", "Segundo" };
        string[] arrayFrecuencia = { "Gigahercio", "Megahercio", "Kilohercio", "Hercio" };
        string[] arrayVelocidad = { "km/h", "Nudo", "m/s", "ft/s", "mi/h" };
        string[] arrayMasa = { "Tonelada", "Kilogramo", "Gramo", "Libra", "Onza" };
        string[] arrayDensidad = { "kg/m3", "g/cm3", "lb/ft3", "oz/in3", "ton/m3" };
        string[] arrayFuerza = { "Newton", "lbf", "Kilopondio" };
        string[] arrayPresión = { "Atmosfera", "Bar", "Pascal", "psi", "Torr" };
        string[] arrayPotencia = { "Vatio", "Caballo_fuerza", "BTU/h" };
        string[] arrayCarga_eléctrica = { "Coulomb", "Electron" };
        string[] arrayFlujo_magnético = { "Weber", "Tm2", "Gauss" };
        string[] arrayIntensidad_magnética = { "Tesla", "Gauss", "Oersted" };





        public Form1()
        {
            InitializeComponent();
            cargarMagnitudes();
            cbMagnitudes.SelectedIndex = 0;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //usado para cerrar la aplicacion
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //evento usado para que el form se mueva clicando el toolstrip
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //usado para dejar en blanco los textbox
            txtcant.Text = "";
            txtResultado.Text = "";
        } 


        //inicio de metodos para cargar los items en el combobox los cuales estan almacenados en los arrays
        public void cargarMagnitudes() 
        {  
            for (int i = 0; i < arrayMagnitudes.Length; i++)
            {
                cbMagnitudes.Items.Add(arrayMagnitudes[i].ToString());
            }

        }

        //se añaden dos veces los items en cada for para los dos combobox
        public void cargarLongitud() 
        {
            for (int i = 0; i < arrayLongitud.Length; i++)
            {
                cbDe.Items.Add(arrayLongitud[i].ToString());
                cbA.Items.Add(arrayLongitud[i].ToString());
            }
        }
        public void cargarÁrea() 
        {
            for (int i = 0; i < arrayÁrea.Length; i++)
            {
                cbDe.Items.Add(arrayÁrea[i].ToString());
                cbA.Items.Add(arrayÁrea[i].ToString());

            }

        }
        public void cargarTemperatura()
        {
            for (int i = 0; i < arrayTemperatura.Length; i++)
            {
                cbDe.Items.Add(arrayTemperatura[i].ToString());
                cbA.Items.Add(arrayTemperatura[i].ToString());

            }

        }
        public void cargarVolumen()
        {
            for (int i = 0; i < arrayVolumen.Length; i++)
            {
                cbDe.Items.Add(arrayVolumen[i].ToString());
                cbA.Items.Add(arrayVolumen[i].ToString());

            }
        }
        public void cargarTiempo()
        {

            for (int i = 0; i < arrayTiempo.Length; i++)
            {
                cbDe.Items.Add(arrayTiempo[i].ToString());
                cbA.Items.Add(arrayTiempo[i].ToString());

            }

        }
        public void cargarFrecuencia()
        {

            for (int i = 0; i < arrayFrecuencia.Length; i++)
            {
                cbDe.Items.Add(arrayFrecuencia[i].ToString());
                cbA.Items.Add(arrayFrecuencia[i].ToString());

            }

        }
        public void cargarVelocidad()
        {

            for (int i = 0; i < arrayVelocidad.Length; i++)
            {
                cbDe.Items.Add(arrayVelocidad[i].ToString());
                cbA.Items.Add(arrayVelocidad[i].ToString());

            }

        }
        public void cargarMasa()
        {

            for (int i = 0; i < arrayMasa.Length; i++)
            {
                cbDe.Items.Add(arrayMasa[i].ToString());
                cbA.Items.Add(arrayMasa[i].ToString());

            }

        }
        public void cargarDensidad()
        {

            for (int i = 0; i < arrayDensidad.Length; i++)
            {
                cbDe.Items.Add(arrayDensidad[i].ToString());
                cbA.Items.Add(arrayDensidad[i].ToString());

            }

        }
        public void cargarFuerza()
        {

            for (int i = 0; i < arrayFuerza.Length; i++)
            {
                cbDe.Items.Add(arrayFuerza[i].ToString());
                cbA.Items.Add(arrayFuerza[i].ToString());

            }

        }
        public void cargarPresión()
        {

            for (int i = 0; i < arrayPresión.Length; i++)
            {
                cbDe.Items.Add(arrayPresión[i].ToString());
                cbA.Items.Add(arrayPresión[i].ToString());

            }

        }
        public void cargarPotencia()
        {

            for (int i = 0; i < arrayPotencia.Length; i++)
            {
                cbDe.Items.Add(arrayPotencia[i].ToString());
                cbA.Items.Add(arrayPotencia[i].ToString());

            }

        }
        public void cargarCarga_eléctrica()
        {

            for (int i = 0; i < arrayCarga_eléctrica.Length; i++)
            {
                cbDe.Items.Add(arrayCarga_eléctrica[i].ToString());
                cbA.Items.Add(arrayCarga_eléctrica[i].ToString());

            }

        }
        public void cargarFlujo_magnético()
        {

            for (int i = 0; i < arrayFlujo_magnético.Length; i++)
            {
                cbDe.Items.Add(arrayFlujo_magnético[i].ToString());
                cbA.Items.Add(arrayFlujo_magnético[i].ToString());

            }

        }

        public void cargarIntensidad_magnética()
        {

            for (int i = 0; i < arrayIntensidad_magnética.Length; i++)
            {
                cbDe.Items.Add(arrayIntensidad_magnética[i].ToString());
                cbA.Items.Add(arrayIntensidad_magnética[i].ToString());

            }

        }

        //fin de metodos 

        private void cbMagnitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este evento se hacen los cambios de magnitudes dependiente de lo elegido, usando la forma de combobox dependientes

            string magnitudes = cbMagnitudes.Text;
            if (magnitudes == "Longitud")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarLongitud();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";


            }
            else if (magnitudes=="Área")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarÁrea();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Temperatura")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarTemperatura();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes=="Volumen")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarVolumen();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Tiempo")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarTiempo();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Frecuencia")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarFrecuencia();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Velocidad")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarVelocidad();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Masa")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarMasa();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Densidad")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarDensidad();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Fuerza")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarFuerza();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Presión")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarPresión();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Potencia")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarPotencia();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Carga_eléctrica")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarCarga_eléctrica();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Flujo_magnético")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarFlujo_magnético();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
            else if (magnitudes == "Intensidad_magnética")
            {
                cbDe.Items.Clear();
                cbA.Items.Clear();
                cargarIntensidad_magnética();
                cbDe.SelectedIndex = 0;
                cbA.SelectedIndex = 0;
                cbDe.SelectedItem = "<";
                cbA.SelectedItem = "<";
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion solo numeros y solo un punto para decimales
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back

                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'));

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //se declaran variables para capturar el texto mostrado en los textbox
            string magnitudes = cbMagnitudes.Text;
            string de = cbDe.Text;
            string a = cbA.Text;

            if (txtcant.Text=="")
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    //Inica Longitud
                    if (magnitudes == "Longitud")
                    {
                        //Kilometro
                        if (de == "Kilometro" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " m");
                        }
                        else if (de == "Kilometro" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100000 + " cm");
                        }
                        else if (de == "Kilometro" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.609 + " mi");
                        }
                        else if (de == "Kilometro" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1093.61 + " yd");
                        }
                        else if (de == "Kilometro" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3280.24 + " ft");
                        }
                        else if (de == "Kilometro" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 39370.1 + " in");
                        }

                        //Metro
                        else if (de == "Metro" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " km");
                        }
                        else if (de == "Metro" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100 + " cm");
                        }
                        else if (de == "Metro" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1609 + " mi");
                        }
                        else if (de == "Metro" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.09361 + " yd");
                        }
                        else if (de == "Metro" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3.28084 + " ft");
                        }
                        else if (de == "Metro" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 39.3701 + " in");
                        }

                        //Centimetro
                        else if (de == "Centímetro" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 100000 + " km");
                        }
                        else if (de == "Centímetro" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 100 + " m");
                        }
                        else if (de == "Centímetro" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 160900 + " mi");
                        }
                        else if (de == "Centímetro" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 91.44 + " yd");
                        }
                        else if (de == "Centímetro" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 30.48 + " ft");
                        }
                        else if (de == "Centímetro" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 2.54 + " in");
                        }

                        //Milla
                        else if (de == "Milla" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.609 + " km");
                        }
                        else if (de == "Milla" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1609 + " m");
                        }
                        else if (de == "Milla" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 160900 + " cm");
                        }
                        else if (de == "Milla" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1760 + " yd");
                        }
                        else if (de == "Milla" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 5280 + " ft");
                        }
                        else if (de == "Milla" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 63360 + " in");
                        }

                        //Yarda
                        else if (de == "Yarda" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1094 + " km");
                        }
                        else if (de == "Yarda" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.094 + " m");
                        }
                        else if (de == "Yarda" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 91.44 + " cm");
                        }
                        else if (de == "Yarda" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1760 + " mi");
                        }
                        else if (de == "Yarda" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3 + " ft");
                        }
                        else if (de == "Yarda" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 36 + " in");
                        }

                        //Pie
                        else if (de == "Pie" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3281 + " km");
                        }
                        else if (de == "Pie" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3.281 + " m");
                        }
                        else if (de == "Pie" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 30.48 + " cm");
                        }
                        else if (de == "Pie" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 5290 + " mi");
                        }
                        else if (de == "Pie" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3 + " yd");
                        }
                        else if (de == "Pie" && a == "Pulgada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 12 + " in");
                        }

                        //Pulgada
                        else if (de == "Pulgada" && a == "Kilometro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 39370 + " km");
                        }
                        else if (de == "Pulgada" && a == "Metro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 39.37 + " m");
                        }
                        else if (de == "Pulgada" && a == "Centímetro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2.54 + " cm");
                        }
                        else if (de == "Pulgada" && a == "Milla")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 63360 + " mi");
                        }
                        else if (de == "Pulgada" && a == "Yarda")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 36 + " yd");
                        }
                        else if (de == "Pulgada" && a == "Pie")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 12 + " ft");
                        }

                    }
                    //Cambio a Area
                    else if (magnitudes == "Área")
                    {
                        //km2
                        if (de == "km²" && a == "m²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000 + " m²");
                        }
                        else if (de == "km²" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.3861 + " mi²");
                        }
                        else if (de == "km²" && a == "yd²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1196000 + " yd²");
                        }
                        else if (de == "km²" && a == "ft²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10763910 + " ft²");
                        }
                        else if (de == "km²" && a == "in²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1550003 + " in²");
                        }
                        else if (de == "km²" && a == "Hectarea")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100 + " ha");
                        }

                        //m2
                        else if (de == "m²" && a == "km²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000 + " km²");
                        }
                        else if (de == "m²" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00000038610 + " mi²");
                        }
                        else if (de == "m²" && a == "yd²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.19599 + " yd²");
                        }
                        else if (de == "m²" && a == "ft²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10.7639 + " ft²");
                        }
                        else if (de == "m²" && a == "in²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1550.0031 + " in²");
                        }
                        else if (de == "m²" && a == "Hectarea")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 10000 + " ha");
                        }

                        //yd2
                        else if (de == "yd²" && a == "km²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.000000936127736 + " km²");
                        }
                        else if (de == "yd²" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00000030976064 + " mi²");
                        }
                        else if (de == "yd²" && a == "m²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.83612736 + " m²");
                        }
                        else if (de == "yd²" && a == "ft²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 9 + " ft²");
                        }
                        else if (de == "yd²" && a == "in²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1296 + " in²");
                        }
                        else if (de == "yd²" && a == "Hectarea")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00008361 + " ha");
                        }

                        //ft2
                        else if (de == "ft²" && a == "km²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.09290304 / 1000000 + " km²");
                        }
                        else if (de == "ft²" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 27878400 + " mi²");
                        }
                        else if (de == "ft²" && a == "m²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.09290304 + " m²");
                        }
                        else if (de == "ft²" && a == "yd²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 9 + " yd²");
                        }
                        else if (de == "ft²" && a == "in²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 144 + " in²");
                        }
                        else if (de == "ft²" && a == "Hectarea")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 10.764 / 10000 + " ha");
                        }

                        //in2
                        else if (de == "in²" && a == "km²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00064516 / 1000000 + " km²");
                        }
                        else if (de == "in²" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 4014489600 + " mi²");
                        }
                        else if (de == "in²" && a == "m²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00064516 + " m²");
                        }
                        else if (de == "in²" && a == "yd²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1296 + " yd²");
                        }
                        else if (de == "in²" && a == "ft²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 144 + " ft²");
                        }
                        else if (de == "in²" && a == "Hectarea")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00064516 / 10000 + " ha");
                        }

                        //ha
                        else if (de == "Hectarea" && a == "km²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 100 + " km²");
                        }
                        else if (de == "Hectarea" && a == "mi²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 259.001 + " mi²");
                        }
                        else if (de == "Hectarea" && a == "m²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10000 + " m²");
                        }
                        else if (de == "Hectarea" && a == "yd²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 11960 + " yd²");
                        }
                        else if (de == "Hectarea" && a == "ft²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 107640 + " ft²");
                        }
                        else if (de == "Hectarea" && a == "in²")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 15500031 + " in²");
                        }

                    }
                    //cambio a Temperatura
                    else if (magnitudes == "Temperatura")
                    {
                        //Celsius
                        if (de == "Celsius" && a == "Kelvin")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) + 273.15 + " Kelvin");
                        }
                        else if (de == "Celsius" && a == "Farenheit")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.8000 + 32.00 + " Farenheit");
                        }

                        //Kelvin
                        else if (de == "Kelvin" && a == "Farenheit")
                        {
                            txtResultado.Text = Convert.ToString((Double.Parse(txtcant.Text) - 273.15) * 1.8 + 32.00 + " Farenheit");
                        }
                        else if (de == "Kelvin" && a == "Celsius")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) - 273.15 + " Celsius");
                        }

                        //Farenheit
                        else if (de == "Farenheit" && a == "Celsius")
                        {
                            txtResultado.Text = Convert.ToString((Double.Parse(txtcant.Text) - 32) / 1.8 + " Celsius");
                        }
                        else if (de == "Farenheit" && a == "Kelvin")
                        {
                            txtResultado.Text = Convert.ToString((Double.Parse(txtcant.Text) - 32) / 1.8 + 273.15 + " Kelvin");
                        }

                    }
                    //cambio a Volumen
                    else if (magnitudes == "Volumen")
                    {
                        //Galon
                        if (de == "Galon" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00378541 + " m3");
                        }
                        else if (de == "Galon" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3.78541 + " L");
                        }
                        else if (de == "Galon" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3785.41 + " ml");
                        }
                        else if (de == "Galon" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.133681 + " ft3");
                        }
                        else if (de == "Galon" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 231 + " in3");
                        }
                        else if (de == "Galon" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 128 + " oz");
                        }

                        //m3
                        else if (de == "m3" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 264.172 + " gal");
                        }
                        else if (de == "m3" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " L");
                        }
                        else if (de == "m3" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000 + " ml");
                        }
                        else if (de == "m3" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 35.3147 + " ft3");
                        }
                        else if (de == "m3" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 61023.7 + " in3");
                        }
                        else if (de == "m3" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 133814.02 + " oz");
                        }

                        //Litro
                        else if (de == "Litro" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.264172 + " gal");
                        }
                        else if (de == "Litro" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " m3");
                        }
                        else if (de == "Litro" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " ml");
                        }
                        else if (de == "Litro" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0353147 + " ft3");
                        }
                        else if (de == "Litro" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 61.0237 + " in3");
                        }
                        else if (de == "Litro" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 33.814 + " oz");
                        }

                        //Mililitro
                        else if (de == "Mililitro" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3785.41 + " gal");
                        }
                        else if (de == "Mililitro" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000 + " m3");
                        }
                        else if (de == "Mililitro" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " L");
                        }
                        else if (de == "Mililitro" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0000353147 + " ft3");
                        }
                        else if (de == "Mililitro" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 16.3871 + " in3");
                        }
                        else if (de == "Mililitro" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 29.5735 + " oz");
                        }

                        //ft3
                        else if (de == "ft3" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 7.48052 + " gal");
                        }
                        else if (de == "ft3" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0283168 + " m3");
                        }
                        else if (de == "ft3" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 28.3168 + " L");
                        }
                        else if (de == "ft3" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 28316800 + " ml");
                        }
                        else if (de == "ft3" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1728 + " in3");
                        }
                        else if (de == "ft3" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 957.506 + " oz");
                        }

                        //in3
                        else if (de == "in3" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 231 + " gal");
                        }
                        else if (de == "in3" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 61023744 + " m3");
                        }
                        else if (de == "in3" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0163871 + " L");
                        }
                        else if (de == "in3" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 16.387 + " ml");
                        }
                        else if (de == "in3" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1728 + " ft3");
                        }
                        else if (de == "in3" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.55411 + " oz");
                        }

                        //Onza
                        else if (de == "Onza" && a == "Galon")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0078125 + " gal");
                        }
                        else if (de == "Onza" && a == "m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0000295735 + " m3");
                        }
                        else if (de == "Onza" && a == "Litro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0295735 + " L");
                        }
                        else if (de == "Onza" && a == "Mililitro")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 295735 + " ml");
                        }
                        else if (de == "Onza" && a == "ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00104 + " ft3");
                        }
                        else if (de == "Onza" && a == "in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.80467 + " in3");
                        }

                    }
                    //cambio a Tiempo
                    else if (magnitudes == "Tiempo")
                    {
                        //Siglo
                        if (de == "Siglo" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10 + " decadas");
                        }
                        else if (de == "Siglo" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100 + " años");
                        }
                        else if (de == "Siglo" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1200 + " meses");
                        }
                        else if (de == "Siglo" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 5256 + " semanas");
                        }
                        else if (de == "Siglo" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 36525 + " dias");
                        }
                        else if (de == "Siglo" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1876000 + " hrs");
                        }
                        else if (de == "Siglo" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 31536000 + " min");
                        }
                        else if (de == "Siglo" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3153600000 + " seg");
                        }

                        //Decada
                        else if (de == "Decada" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.1 + " siglos");
                        }
                        else if (de == "Decada" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10 + " años");
                        }
                        else if (de == "Decada" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 120 + " meses");
                        }
                        else if (de == "Decada" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 521.429 + " semanas");
                        }
                        else if (de == "Decada" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3650 + " dias");
                        }
                        else if (de == "Decada" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 87600 + " hrs");
                        }
                        else if (de == "Decada" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 5256000 + " min");
                        }
                        else if (de == "Decada" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 315567360 + " seg");
                        }

                        //Año
                        else if (de == "Año" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.01 + " siglos");
                        }
                        else if (de == "Año" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 10 + " decadas");
                        }
                        else if (de == "Año" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 12 + " meses");
                        }
                        else if (de == "Año" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 52.14 + " semanas");
                        }
                        else if (de == "Año" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 365 + " dias");
                        }
                        else if (de == "Año" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 8766 + " hrs");
                        }
                        else if (de == "Año" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 525600 + " min");
                        }
                        else if (de == "Año" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 331536000 + " seg");
                        }

                        //Mes
                        else if (de == "Mes" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1200 + " siglos");
                        }
                        else if (de == "Mes" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 120 + " decadas");
                        }
                        else if (de == "Mes" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 12 + " años");
                        }
                        else if (de == "Mes" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 4 + " semanas");
                        }
                        else if (de == "Mes" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 30 + " dias");
                        }
                        else if (de == "Mes" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 720 + " hrs");
                        }
                        else if (de == "Mes" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 43200 + " min");
                        }
                        else if (de == "Mes" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2592000 + " seg");
                        }

                        //Semana
                        else if (de == "Semana" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 52143 + " siglos");
                        }
                        else if (de == "Semana" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 521.43 + " decadas");
                        }
                        else if (de == "Semana" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 52.143 + " años");
                        }
                        else if (de == "Semana" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 4 + " meses");
                        }
                        else if (de == "Semana" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 7 + " dias");
                        }
                        else if (de == "Semana" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 168 + " hrs");
                        }
                        else if (de == "Semana" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 10080 + " min");
                        }
                        else if (de == "Semana" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 604800 + " seg");
                        }

                        //Dia
                        else if (de == "Dia" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 36500 + " siglos");
                        }
                        else if (de == "Dia" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3650 + " decadas");
                        }
                        else if (de == "Dia" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 365 + " años");
                        }
                        else if (de == "Dia" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 30.417 + " meses");
                        }
                        else if (de == "Dia" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 7 + " semanas");
                        }
                        else if (de == "Dia" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 24 + " hrs");
                        }
                        else if (de == "Dia" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1440 + " min");
                        }
                        else if (de == "Dia" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 86400 + " seg");
                        }

                        //Hora
                        else if (de == "Hora" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 876000 + " siglos");
                        }
                        else if (de == "Hora" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 87600 + " decadas");
                        }
                        else if (de == "Hora" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 8760 + " años");
                        }
                        else if (de == "Hora" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 730 + " meses");
                        }
                        else if (de == "Hora" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 168 + " semanas");
                        }
                        else if (de == "Hora" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 24 + " dias");
                        }
                        else if (de == "Hora" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 60 + " min");
                        }
                        else if (de == "Hora" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3600 + " seg");
                        }

                        //Minuto
                        else if (de == "Minuto" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.000000019 + " siglos");
                        }
                        else if (de == "Minuto" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 5256000 + " decadas");
                        }
                        else if (de == "Minuto" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 8525600 + " años");
                        }
                        else if (de == "Minuto" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 43800 + " meses");
                        }
                        else if (de == "Minuto" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 10080 + " semanas");
                        }
                        else if (de == "Minuto" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1440 + " dias");
                        }
                        else if (de == "Minuto" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 60 + " hrs");
                        }
                        else if (de == "Minuto" && a == "Segundo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 60 + " seg");
                        }

                        //Segundo
                        else if (de == "Segundo" && a == "Siglo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3153600000 + " siglos");
                        }
                        else if (de == "Segundo" && a == "Decada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 315360000 + " decadas");
                        }
                        else if (de == "Segundo" && a == "Año")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 31536000 + " años");
                        }
                        else if (de == "Segundo" && a == "Mes")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 2628000 + " meses");
                        }
                        else if (de == "Segundo" && a == "Semana")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 604800 + " semanas");
                        }
                        else if (de == "Segundo" && a == "Dia")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 86400 + " dias");
                        }
                        else if (de == "Segundo" && a == "Hora")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3600 + " hrs");
                        }
                        else if (de == "Segundo" && a == "Minuto")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 60 + " min");
                        }

                    }
                    //cambio a Frecuencia
                    else if (magnitudes == "Frecuencia")
                    {
                        //Gigahercio
                        if (de == "Gigahercio" && a == "Megahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " MHz");
                        }
                        else if (de == "Gigahercio" && a == "Kilohercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000 + " kHz");
                        }
                        else if (de == "Gigahercio" && a == "Hercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000000 + " Hz");
                        }

                        //Megahercio
                        else if (de == "Megahercio" && a == "Gigahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " GHz");
                        }
                        else if (de == "Megahercio" && a == "Kilohercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " kHz");
                        }
                        else if (de == "Megahercio" && a == "Hercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000 + " Hz");
                        }

                        //Kilohercio
                        else if (de == "Kilohercio" && a == "Gigahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000 + " GHz");
                        }
                        else if (de == "Kilohercio" && a == "Megahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " MHz");
                        }
                        else if (de == "Kilohercio" && a == "Hercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " Hz");
                        }

                        //Hercio
                        else if (de == "Hercio" && a == "Megahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000 + " MHz");
                        }
                        else if (de == "Hercio" && a == "Kilohercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " kHz");
                        }
                        else if (de == "Hercio" && a == "Gigahercio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000000 + " GHz");
                        }

                    }
                    //cambio a Velocidad
                    else if (magnitudes == "Velocidad")
                    {
                        //km/h
                        if (de == "km/h" && a == "Nudo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.852 + " kt");
                        }
                        else if (de == "km/h" && a == "m/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3.6 + " m/s");
                        }
                        else if (de == "km/h" && a == "ft/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.097 + " ft/s");
                        }
                        else if (de == "km/h" && a == "mi/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.609 + " mi/h");
                        }

                        //Nudo
                        else if (de == "Nudo" && a == "km/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.852 + " km/h");
                        }
                        else if (de == "Nudo" && a == "m/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.944 + " m/s");
                        }
                        else if (de == "Nudo" && a == "ft/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.688 + " ft/s");
                        }
                        else if (de == "Nudo" && a == "mi/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.151 + " mi/h");
                        }

                        //m/s
                        else if (de == "m/s" && a == "Nudo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.944 + " kt");
                        }
                        else if (de == "m/s" && a == "km/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3.6 + " km/h");
                        }
                        else if (de == "m/s" && a == "ft/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 3.281 + " ft/s");
                        }
                        else if (de == "m/s" && a == "mi/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2.237 + " mi/h");
                        }

                        //ft/s
                        else if (de == "ft/s" && a == "Nudo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.688 + " kt");
                        }
                        else if (de == "ft/s" && a == "m/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 3.281 + " m/s");
                        }
                        else if (de == "ft/s" && a == "km/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.097 + " km/h");
                        }
                        else if (de == "ft/s" && a == "mi/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.467 + " mi/h");
                        }

                        //mi/h
                        else if (de == "mi/h" && a == "Nudo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1.151 + " kt");
                        }
                        else if (de == "mi/h" && a == "m/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 2.237 + " m/s");
                        }
                        else if (de == "mi/h" && a == "ft/s")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.467 + " ft/s");
                        }
                        else if (de == "mi/h" && a == "km/h")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.609 + " km/h");
                        }

                    }
                    //cambio a Masa
                    else if (magnitudes == "Masa")
                    {
                        //Tonelada
                        if (de == "Tonelada" && a == "Kilogramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " kg");
                        }
                        else if (de == "Tonelada" && a == "Gramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000000 + " gr");
                        }
                        else if (de == "Tonelada" && a == "Libra")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2205 + " lb");
                        }
                        else if (de == "Tonelada" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 35274 + " oz");
                        }

                        //Kilogramo
                        else if (de == "Kilogramo" && a == "Tonelada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " ton");
                        }
                        else if (de == "Kilogramo" && a == "Gramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " gr");
                        }
                        else if (de == "Kilogramo" && a == "Libra")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2.205 + " lb");
                        }
                        else if (de == "Kilogramo" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 35.274 + " oz");
                        }

                        //Gramo
                        else if (de == "Gramo" && a == "Tonelada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000000 + " ton");
                        }
                        else if (de == "Gramo" && a == "Kilogramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 1000 + " kg");
                        }
                        else if (de == "Gramo" && a == "Libra")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 453.6 + " lb");
                        }
                        else if (de == "Gramo" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 28.35 + " oz");
                        }

                        //Libra
                        else if (de == "Libra" && a == "Tonelada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 2205 + " ton");
                        }
                        else if (de == "Libra" && a == "Kilogramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 2.205 + " kg");
                        }
                        else if (de == "Libra" && a == "Gramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 453.6 + " gr");
                        }
                        else if (de == "Libra" && a == "Onza")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 16 + " oz");
                        }

                        //Onza
                        else if (de == "Onza" && a == "Tonelada")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 35274 + " ton");
                        }
                        else if (de == "Onza" && a == "Kilogramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 35.274 + " kg");
                        }
                        else if (de == "Onza" && a == "Gramo")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 28.35 + " gr");
                        }
                        else if (de == "Onza" && a == "Libra")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) / 16 + " lb");
                        }

                    }
                    //cambio a Densidad
                    else if (magnitudes == "Densidad")
                    {
                        //kg/m3
                        if (de == "kg/m3" && a == "g/cm3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.001 + " g/cm3");
                        }
                        else if (de == "kg/m3" && a == "lb/ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0624 + " lb/ft3");
                        }
                        else if (de == "kg/m3" && a == "oz/in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0000361 + " oz/in3");
                        }
                        else if (de == "kg/m3" && a == "ton/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.001 + " ton/m3");
                        }

                        //g/cm3
                        else if (de == "g/cm3" && a == "kg/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " kg/m3");
                        }
                        else if (de == "g/cm3" && a == "lb/ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 62.4 + " lb/ft3");
                        }
                        else if (de == "g/cm3" && a == "oz/in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0361 + " oz/in3");
                        }
                        else if (de == "g/cm3" && a == "ton/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.001 + " ton/m3");
                        }

                        //lb/ft3
                        else if (de == "lb/ft3" && a == "kg/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 16.0185 + " kg/m3");
                        }
                        else if (de == "lb/ft3" && a == "g/cm3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0160185 + " g/cm3");
                        }
                        else if (de == "lb/ft3" && a == "oz/in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.000578036 + " oz/in3");
                        }
                        else if (de == "lb/ft3" && a == "ton/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0160185 + " ton/m3");
                        }

                        //oz/in3
                        else if (de == "oz/in3" && a == "kg/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1729.99 + " kg/m3");
                        }
                        else if (de == "oz/in3" && a == "g/cm3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 27.6799 + " g/cm3");
                        }
                        else if (de == "oz/in3" && a == "lb/ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.00115 + " lb/ft3");
                        }
                        else if (de == "oz/in3" && a == "ton/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.00173 + " ton/m3");
                        }

                        //ton/m3
                        else if (de == "ton/m3" && a == "kg/m3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1000 + " kg/m3");
                        }
                        else if (de == "ton/m3" && a == "g/cm3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1 + " g/cm3");
                        }
                        else if (de == "ton/m3" && a == "lb/ft3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 62.4279 + " lb/ft3");
                        }
                        else if (de == "ton/m3" && a == "oz/in3")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.0361273 + " oz/in3");
                        }

                    }
                    //cambio a Fuerza
                    else if (magnitudes == "Fuerza")
                    {
                        //Newton
                        if (de == "Newton" && a == "lbf")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.224809 + " lbf");
                        }
                        else if (de == "Newton" && a == "Kilopondio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.101972 + " kp");
                        }

                        //lbf
                        else if (de == "lbf" && a == "Newton")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 4.44822 + " N");
                        }
                        else if (de == "lbf" && a == "Kilopondio")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.453592 + " kp");
                        }

                        //Kilopondio
                        else if (de == "Kilopondio" && a == "Newton")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 9.80665 + " N");
                        }
                        else if (de == "Kilopondio" && a == "lbf")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 2.20462 + " lbf");
                        }

                    }
                    //cambio a Presión
                    else if (magnitudes == "Presión")
                    {
                        //Atmosfera
                        if (de == "Atmosfera" && a == "Bar")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 1.01325 + " bar");
                        }
                        else if (de == "Atmosfera" && a == "Pascal")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 101325 + " Pa");
                        }
                        else if (de == "Atmosfera" && a == "psi")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 14.6959 + " psi");
                        }
                        else if (de == "Atmosfera" && a == "Torr")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 760 + " Torr");
                        }

                        //bar
                        else if (de == "Bar" && a == "Atmosfera")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.986923 + " atm");
                        }
                        else if (de == "Bar" && a == "Pascal")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100000 + " Pa");
                        }
                        else if (de == "Bar" && a == "psi")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 14.5038 + " psi");
                        }
                        else if (de == "Bar" && a == "Torr")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 750.062 + " Torr");
                        }

                        //Pascal
                        else if (de == "Pascal" && a == "Atmosfera")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 0.986923 + " atm");
                        }
                        else if (de == "Pascal" && a == "Bar")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 100000 + " bar");
                        }
                        else if (de == "Pascal" && a == "psi")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 14.5038 + " psi");
                        }
                        else if (de == "Pascal" && a == "Torr")
                        {
                            txtResultado.Text = Convert.ToString(Double.Parse(txtcant.Text) * 750.062 + " Torr");
                        }

                    }

                }


                catch (Exception)
                {

                    MessageBox.Show("No ha introdudcido valores o estos eran invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //se usa para que no se usen unidades de conversion semejantes en los combobox
                if (de == a)
                {
                    MessageBox.Show("Ha elegido conversiones iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
}
