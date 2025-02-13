services.AddAuthentication("Project2Scheme")
    .AddCookie("Project2Scheme", options => {
        options.Cookie.Name = "Project2.Cookie"; // Уникальное имя куки
    });
https://docs.google.com/presentation/d/1FeH8Kd_h7XCPg-6CJZTBiUQCTm2-ctdYxIxyQsbHgQk/edit?usp=sharing
