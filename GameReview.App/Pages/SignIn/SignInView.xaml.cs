﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.App.Pages.SignIn;

public partial class SignInView : ContentPage
{
    public SignInView(object bindingContext)
    {
        InitializeComponent();

        BindingContext = bindingContext;
    }
}