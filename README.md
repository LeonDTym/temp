services.AddAuthentication("Project2Scheme")
    .AddCookie("Project2Scheme", options => {
        options.Cookie.Name = "Project2.Cookie"; // Уникальное имя куки
    });
