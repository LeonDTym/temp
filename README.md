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


.custom { 
 width: 200px; 
 padding: 0px; 
 margin: 0px; 
} 
.gradient-page { 
 width: 100%; 
 min-height: 200px; 
 padding: 0px; 
 margin: 0px; 
 border-radius: 20px; 
 display: flex; 
 justify-content: center; 
 align-items: center; 
}
<div class="custom @(await Model.GetSection(Api))" style="border: none; background-color: transparent;"> 
  <div class="gradient-page"> 
   <div> 
    <a href="@WebApp.Url(Model.Body.Page.Slug)">@Model.GetTitle()</a> 
   </div> 
  </div> 
 </div> 



Конечно! Давайте создадим HTML-код, который будет иметь полупрозрачный градиент над изображением, а справа от изображения будет текст с таким же градиентом.

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        .image-container {
            position: relative;
            display: inline-block;
        }

        .image {
            width: 300px; /* Укажите размер изображения */
            height: auto;
        }

        .gradient-overlay {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: linear-gradient(to bottom, rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.1));
        }

        .text {
            position: absolute;
            top: 50%;
            right: 20px; /* Расстояние от правого края */
            transform: translateY(-50%);
            color: white;
            font-size: 18px;
            font-weight: bold;
            text-align: right;
            background: linear-gradient(to bottom, #ff9900, #ff3300); /* Градиент для текста */
            padding: 10px;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <div class="image-container">
        <img src="your-image.jpg" alt="Your Image" class="image">
        <div class="gradient-overlay"></div>
        <div class="text">Ваш текст</div>
    </div>
</body>
</html>
```

Замените `"your-image.jpg"` на путь к вашему изображению. Вы также можете настроить размер изображения, цвета градиента и текста, а также расположение текста справа от изображения. Удачи с вашим проектом! 🚀

Источник: беседа с Bing, 10.04.2024
(1) undefined. https://skillbox.ru/media/code/7-neyrosetey-dlya-programmistov-kak-pisat-kod-bystree-i-luchshe/.
(2) undefined. https://proglib.io/p/25-besplatnyh-ai-instrumentov-dlya-razrabotchikov-2023-10-18.
(3) undefined. https://journal.tinkoff.ru/short/ai-for-all/.
(4) html - Gradient and text over image - Stack Overflow. https://stackoverflow.com/questions/45332759/gradient-and-text-over-image.
(5) How to Create CSS Text Gradient - W3Schools. https://www.w3schools.in/css3/gradient-text.
(6) Creating Gradient Text with HTML and CSS - Coding Dude. https://www.coding-dude.com/wp/css/gradient-text/.
(7) undefined. https://www.upload.ee/image/7272952/case-studies-item.png.
(8) undefined. https://www.upload.ee/image/7272954/left-arrow.png.
(9) How TO - Position Text Over an Image - W3Schools. https://www.w3schools.com/howto/howto_css_image_text.asp.
(10) html - Gradient over img tag using css - Stack Overflow. https://stackoverflow.com/questions/23935758/gradient-over-img-tag-using-css.
(11) How to add a gradient overlay to a background image using just CSS and HTML. https://webdevetc.com/blog/how-to-add-a-gradient-overlay-to-a-background-image-using-just-css-and-html/.
(12) Using CSS gradients - CSS: Cascading Style Sheets | MDN - MDN Web Docs. https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Images/Using_CSS_gradients.
(13) github.com. https://github.com/EleanorEllingson/web-dev/tree/b2f2a382e77a20fd6895677c8b8f402ac4bae352/7-bank-project%2F1-template-route%2Ftranslations%2FREADME.ko.md.
.gradient-page {
  width: 100%;
  min-height: 200px;
  padding: 0px;
  margin: 0px;
  border-radius: 20px;
  display: flex;
  justify-content: center;
  align-items: center;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
