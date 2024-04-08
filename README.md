# temp
https://www.dotnetxp.com/download-csv-file-asp-net-mvc/

@model Piranha.Extend.Blocks.VideoBlock
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
<style>    
    #video_box {
        position: relative;
    }

const queryAdvInput = document.getElementById("queryAdv");
const archiveChbx = document.getElementById("archiveChbx");
const fullTextChbx = document.getElementById("fullTextChbx");

if (sessionStorage.getItem("query") != null) {
  queryAdvInput.value = sessionStorage.getItem("query");
}

if (sessionStorage.getItem("arcChbx") === "true") {
  archiveChbx.checked = true;
} else {
  archiveChbx.checked = false;
}

if (sessionStorage.getItem("fullChbx") === "true") {
  fullTextChbx.checked = true;
} else {
  fullTextChbx.checked = false;
}

document.getElementById("searchForm").addEventListener("submit", function (event) {
  const query = queryAdvInput.value;
  const arcChbx = archiveChbx.checked;
  const fullChbx = fullTextChbx.checked;

  sessionStorage.setItem("query", query);
  sessionStorage.setItem("arcChbx", arcChbx);
  sessionStorage.setItem("fullChbx", fullChbx);
});


	[HttpPost]
	[Route("/karera/anketa")]
	public async Task<IActionResult> Question(QuestionView model)
	{
		if(string.IsNullOrEmpty(model.Ability))
		{
			model.Ability = "-";
		}
		if (string.IsNullOrEmpty(model.TDom) & string.IsNullOrEmpty(model.TMob) & string.IsNullOrEmpty(model.TRab))
		{
			
			ModelState.AddModelError("TelErr", "Хотя бы один телефон должен быть заполнен");
		}
		if (ModelState.IsValid)
		{
			await _repository.AddItem(model.Trasnform());
			ViewBag.Message = "Соси";
			return Redirect("/karera/anketa");
		}
		return View(model);
	}

<div class="form__group field">
  <input type="input" class="form__field" placeholder="Name" name="name" id='name' required />
  <label for="name" class="form__label">Name</label>
</div>
<style>
$primary: #11998e;
$secondary: #38ef7d;
$white: #fff;
$gray: #9b9b9b;
.form__group {
  position: relative;
  padding: 15px 0 0;
  margin-top: 10px;
  width: 50%;
}

.form__field {
  font-family: inherit;
  width: 100%;
  border: 0;
  border-bottom: 2px solid $gray;
  outline: 0;
  font-size: 1.3rem;
  color: $white;
  padding: 7px 0;
  background: transparent;
  transition: border-color 0.2s;

  &::placeholder {
    color: transparent;
  }

  &:placeholder-shown ~ .form__label {
    font-size: 1.3rem;
    cursor: text;
    top: 20px;
  }
}

.form__label {
  position: absolute;
  top: 0;
  display: block;
  transition: 0.2s;
  font-size: 1rem;
  color: $gray;
}

.form__field:focus {
  ~ .form__label {
    position: absolute;
    top: 0;
    display: block;
</style>




<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Gradient Text Block</title>
    <style>
        .container {
            display: flex;
            align-items: center;
            justify-content: space-between;
            padding: 10px;
            background-image: linear-gradient(to right, #ff8c00, #ff00ff);
            color: white;
            border-radius: 5px;
            margin: 10px;
        }
        img {
            width: 50px;
            height: 50px;
            margin-right: 10px;
        }
    </style>
</head>
<body>
    <div class="container">
        <img src="image.jpg" alt="Image">
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
    </div>
</body>
</html>


using System;

public class DateCalculator
{
    public static string GetCurrentDate(int num)
    {
        DateTime currentDate = DateTime.Now;
        int currentYear = currentDate.Year;
        int currentMonth = currentDate.Month;
        int year;
        string month;

        switch (num)
        {
            case 1:
                year = currentYear + 3;
                month = "08";
                break;
            case 2:
                year = currentYear + 2;
                month = "08";
                break;
            case 3:
                year = currentYear + 1;
                month = "08";
                break;
            case 4:
                year = currentMonth >= 6 ? currentYear + 1 : currentYear;
                month = "08";
                break;
            case 5:
                year = currentYear + 4;
                month = "06";
                break;
            case 6:
                year = currentYear + 3;
                month = "06";
                break;
            case 7:
                year = currentYear + 2;
                month = "06";
                break;
            case 8:
                year = currentYear + 1;
                month = "06";
                break;
            case 9:
                year = currentMonth >= 6 ? currentYear + 1 : currentYear;
                month = "06";
                break;
            case 10:
                year = currentYear + 1;
                month = "06";
                break;
            case 11:
                year = currentMonth >= 6 ? currentYear + 1 : currentYear;
                month = "06";
                break;
            default:
                return "invalid year";
        }

        return $"{month}.{year}";
    }
}
