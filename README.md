# temp
https://www.dotnetxp.com/download-csv-file-asp-net-mvc/

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <style>
    .container {
      position: relative;
      width: 300px;
      height: 200px;
    }

    .image {
      width: 100%;
      height: 100%;
      object-fit: cover;
    }

    .overlay {
      position: absolute;
      bottom: 0;
      left: 0;
      width: 100%;
      height: 50px;
      background: linear-gradient(to bottom, rgba(255, 0, 0, 0.5), rgba(0, 0, 255, 0.5));
    }
  </style>
</head>
<body>
  <div class="container">
    <img src="image.jpg" alt="image" class="image">
    <div class="overlay"></div>
  </div>
</body>
</html>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <style>
    .wave {
      width: 200px;
      height: 100px;
      position: relative;
      background: linear-gradient(to bottom, rgba(255, 255, 255, 0), rgba(255, 255, 255, 1));
      margin: 50px auto;
    }

    .wave:before,
    .wave:after {
      content: '';
      position: absolute;
      width: 100%;
      height: 20px;
      bottom: 0;
      background: #fff;
    }

    .wave:before {
      border-radius: 50% 50% 0 0;
    }

    .wave:after {
      border-radius: 0 0 50% 50%;
      bottom: 20px;
    }
  </style>
</head>
<body>
  <div class="wave"></div>
</body>
</html>

