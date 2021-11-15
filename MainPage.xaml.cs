<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XF_BasicBinding.MainPage">
    <StackLayout Padding="10, 0">
        <Label x:Name="label1"
               Text="TEXT"
               FontSize="40"
               HorizontalOptions="Center"
               VerticalOptions="CenterAndExpand" />

        <Slider x:Name="slider1"
                Maximum="180" BackgroundColor="Red"
                VerticalOptions="CenterAndExpand" />
       
        <Label x:Name="label2"
               Text="TEXT"
               FontSize="40"
               HorizontalOptions="Center"
               VerticalOptions="CenterAndExpand" />
        
        <Slider x:Name="slider2"
                    VerticalOptions="CenterAndExpand"
                    Value="{Binding Source={x:Reference label2},
                     Path=Opacity}" />

        <Label Text="TEXT"
               FontSize="40"
               HorizontalOptions="Center"
               VerticalOptions="CenterAndExpand"
               BindingContext="{x:Reference Name=slider3}"
               Rotation="{Binding Path=Value}" />

        <Slider x:Name="slider3"
                Maximum="360" BackgroundColor="Blue"
                VerticalOptions="CenterAndExpand" />


        <Entry x:Name="name" Placeholder="Enter your name!!!" />
        <Switch x:Name="s1" OnColor="Red" />
        
    </StackLayout>
</ContentPage>
