# temp
https://www.dotnetxp.com/download-csv-file-asp-net-mvc/

@model Piranha.Extend.Blocks.VideoBlock
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
<style>    
    #video_box {
        position: relative;
    }

    #video_overlays {
        position: absolute;
        width: 100%;
        min-height: 100%;
        background: rgb(34,193,195);
        background: linear-gradient(90deg, rgba(34,193,195,1) 0%, rgba(253,187,45,1) 39%, rgba(253,187,45,0.644782913165266) 59%, rgba(253,187,45,0) 100%);
        z-index: 100;
      /*   bottom: 10px;
        left: 10px; */
        justify-content: center;
        align-items: center;
        display: flex;
    }
    
    * {
  margin: 0;
  padding: 0;
  outline: 0;
  scroll-behavior: smooth;
  transition: 0.5s ease-in;
}

.circle {
  height: 100px;
  width: 100px;
  border-radius: 50%;
  background-color: #333;
  display: grid;
  place-content: center;
        justify-content: center;
        align-items: center;
  animation: grow 1s infinite;
}
.circle > span {
  color: #eee;
  font-size: 50px;
}

@@keyframes grow {
  from {
    box-shadow: 0px 0px 1em #000;
  }
  to {
    box-shadow: 0px 0px 3em #000;
  }
}

</style>

<div id="video_box">
    <div id="video_overlays">
        <div class="circle">

            <span class="material-icons">
                play_circle
            </span>

        </div>
    </div>
<video class="mw-100" controls>
    <source src="@Url.Content(Model.Body)">
    Your browser does not support the video tag.
</video>
</div>

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


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> list1 = new List<string> {"apple", "banana", "orange", "grape" };
        List<string> list2 = new List<string> {"apple", "grape", "kiwi"};

        IEnumerable<string> difference = list1.Except(list2).Union(list2.Except(list1));

        Console.WriteLine("Non-exact matches:");
        foreach (string item in difference)
        {
            Console.WriteLine(item);
        }
    }
}


