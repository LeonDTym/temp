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


1. "Онлайн-платформа департамента персонала: удобство и эффективность"
Наш сайт департамента персонала предлагает сотрудникам и руководителям дополнительные возможности для управления кадровыми вопросами. Благодаря онлайн-сервисам, можно быстро подать заявку на отпуск, получить информацию о текущих вакансиях и процессе найма, а также взаимодействовать с HR-специалистами в реальном времени.

2. "Развитие карьеры через сайт департамента персонала"
Наш сайт департамента персонала не только предоставляет информацию о вакансиях и отпусках, но и создает условия для развития карьеры сотрудников. Здесь можно пройти онлайн-курсы и тренинги, оценить свои навыки и способности, а также получить консультацию по планированию карьеры и профессионального роста.

3. "Как использовать сайт департамента персонала для повышения производительности"
Используя функционал сайта департамента персонала, сотрудники могут организовать свою работу более эффективно. Здесь можно найти полезные инструменты для управления рабочим временем, обмена документами и информацией, а также для обратной связи и участия в корпоративных проектах. Это помогает повысить производительность и эффективность работы как индивидуально, так и в команде.
