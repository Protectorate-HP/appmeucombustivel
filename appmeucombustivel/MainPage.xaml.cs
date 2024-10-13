namespace appmeucombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                String msg = "";

                if (etanol <= (gasolina * 0.70))
                {
                    msg = "o etanol esta compensando mais";
                }
                else
                {
                    msg = "a gasolina esta compensando mais";
                }
                DisplayAlert("Calculado", msg, "Ok");
            } catch (Exception ex)
            {
                DisplayAlert("Aff", ex.Message, "Fechar");
            }

        }
    }
}
