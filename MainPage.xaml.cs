namespace Ejercicio4;

public partial class MainPage : ContentPage
{

    public MainPage()

    {

        InitializeComponent();

    }

    ///<Summary>
    ///<Createddate>06-07-2023</Createddate>
    ///<company>SandBox</company>
    ///<lastmodificationdate>06-07-2023</lastmodificationdate>
    ///<lastmodificationdescription>Ninguna</lastmodificationdescription>
    ///<lastmodifierautor>Nery</lastmodifierautor>
    ///</Summary>

    private void OnCounterClicked(object sender, EventArgs e)

    {

        // Declaramos las variables correpondientes y hacemos sus operaciones debidas //

        int N, C, Cubi;

        N = Convert.ToInt32(NumeroEnteroEntry.Text);

        C = (N * N);

        ResultadoCuadrado.Text = Convert.ToString(C);

        Cubi = (N * N * N);

        ResultadoCubo.Text = Convert.ToString(Cubi);

    }
}
