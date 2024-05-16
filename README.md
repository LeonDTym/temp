<html>
  <head>
    <title>Цены на металлы, камни и монеты</title>
    <style>
      table {
        border-collapse: collapse;
        width: 100%;
      }
      th,
      td {
        border: 1px solid black;
        padding: 8px;
        text-align: left;
      }
      th {
        background-color: #f2f2f2;
      }
    </style>
  </head>
  <body>
    <h1>Цены на металлы, камни и монеты</h1>
    <table>
      <thead>
        <tr>
          <th>№</th>
          <th>Тип Ремпламента</th>
          <th>Цена</th>
          <th>Валюта</th>
          <th>Дата Утверждения</th>
          <th>Создатель</th>
          <th>Утвердитель</th>
          <th>Архивный номер</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>1</td>
          <td>Принято внешней системой 795-15-009ERM/18</td>
          <td>Авансы по валютам</td>
          <td>16765</td>
          <td>79500620240402-001</td>
          <td>02/04/2024 00:00</td>
          <td>02/04/2024 14:34</td>
          <td>su_ermspec</td>
          <td>su_ermpodpisant</td>
        </tr>
        <tr>
          <td>2</td>
          <td>Принято внешней системой 705.15.07.001/02</td>
          <td>Курсы БПК</td>
          <td>16763</td>
          <td>70500520210102.003</td>
          <td>02/01/2024 14:41</td>
          <td>02/01/2021 14:30</td>
          <td>Su ormspec</td>
          <td>Su ormpodpisant</td>
        </tr>
        <tr>
          <td>3</td>
          <td>Принято внешней системой 795-15-07-009ERM/99</td>
          <td>Цены на камни</td>
          <td>16771</td>
          <td>79500420240402-002</td>
          <td>02/04/2024 14:50</td>
          <td>02/04/2024 14:40</td>
          <td>su_ermspec</td>
          <td>su_ermpodpisant</td>
        </tr>
        <tr>
          <td>4</td>
          <td>Принято внешней системой 795-15-07-009ERM/98</td>
          <td>Цены на монеты</td>
          <td>16769</td>
          <td>79500120240402-002</td>
          <td>02/04/2024 15:01</td>
          <td>02/04/2024 14:35</td>
          <td>su_ermspec</td>
          <td>su_ermpodpisant</td>
        </tr>
      </tbody>
    </table>
  </body>
</html>




<form>
  <table>
    <tr>
      <td>Фильтр</td>
      <td>
        <input type="number" id="filter-number" />
        <label for="filter-number">Номер</label>
      </td>
      <td>
        <input type="text" id="archive-number" />
        <label for="archive-number">Архивный номер</label>
      </td>
      <td>
        <input type="text" id="created-by" />
        <label for="created-by">Кем создано</label>
      </td>
    </tr>
    <tr>
      <td>Тип</td>
      <td>
        <select id="type">
          <option value="Bce">Bce</option>
          <!-- Add more options here -->
        </select>
      </td>
      <td>Отклоненные</td>
      <td>
        <input type="checkbox" id="automatic" />
        <label for="automatic">Автоматические</label>
      </td>
    </tr>
    <tr>
      <td>Переходы статусов</td>
      <td>
        <select id="status-transitions">
          <option value="including">включая</option>
          <option value="excluding">исключая</option>
        </select>
      </td>
      <td>
        <button type="reset">Сбросить фильтр</button>
      </td>
    </tr>
    <tr>
      <td>Вступление с...</td>
      <td>
        <input type="datetime-local" id="start-date" value="2024-04-01T00:00" />
      </td>
      <td>по...</td>
      <td>
        <input type="datetime-local" id="end-date" value="2024-04-30T23:59" />
      </td>
    </tr>
    <tr>
      <td>Статус</td>
      <td>
        <select id="status">
          <option value="Bce">Bce</option>
          <option value="archived">Архивные</option>
          <option value="with-notification">С уведомлением</option>
        </select>
      </td>
      <td>
        <button type="reset">Сбросить</button>
      </td>
    </tr>
    <tr>
      <td>Выберите пользователей</td>
      <td>
        <!-- Add user selection component here -->
      </td>
    </tr>
    <tr>
      <td>Выберите статусы</td>
      <td>
        <!-- Add status selection component here -->
      </td>
    </tr>
    <tr>
      <td colspan="4">
        <button type="submit">Применить</button>
      </td>
    </tr>
  </table>
</form>
