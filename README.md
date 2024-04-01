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

