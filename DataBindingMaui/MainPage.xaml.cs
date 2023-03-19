using DataBindingMaui.Models;

namespace DataBindingMaui;

public partial class MainPage : ContentPage
{
    private Person _person;

    public MainPage()
    {
        InitializeComponent();

        _person = new Person
        {
            Name = "John",
            Phone = "9999",
            Address = "X Address"
        };

        BindingContext = _person;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        //person.Name = "Peter";
        //person.Phone = "0000";
        //person.Address = "New Address";

        _person = new Person
        {
            Name = "Peter",
            Phone = "0000",
            Address = "New Address"
        };


        // programatically binding
        txtName.BindingContext = _person;
        txtName.SetBinding(Label.TextProperty, "Name");

        var personBinding =
          new Binding
          {
              Source = _person,
              Path = "Name"
          };

        txtName.SetBinding(Label.TextProperty, personBinding);


    }
}
