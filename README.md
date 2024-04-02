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
