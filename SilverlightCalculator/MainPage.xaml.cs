using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightCalculator
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            HtmlPage.RegisterScriptableObject("calculator", new Calculator());
        }
    }
}
