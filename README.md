
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Обучающиеся Импорт обучающихся</title>
    <style>
        /* Add some basic styling to make the page look decent */
        body {
            font-family: Arial, sans-serif;
        }
       .filter {
            margin-bottom: 20px;
        }
       .table-container {
            overflow-x: auto;
        }
        table {
            border-collapse: collapse;
            width: 100%;
        }
        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }
        th {
            background-color: #f0f0f0;
        }
    </style>
</head>
<body>
    <h1>Обучающиеся Импорт обучающихся</h1>
    <div class="filter">
        <label>Фильтр</label>
        <select>
            <option value="">Пользователь Служебный</option>
            <!-- Add more options here -->
        </select>
    </div>
    <div class="table-container">
        <table>
            <thead>
                <tr>
                    <th>Фамилия</th>
                    <th>Имя</th>
                    <th>Отчество</th>
                    <th>Дата рождения</th>
                    <th>Факультет</th>
                    <th>Форма обучения</th>
                    <th>№ Студенческого</th>
                    <th>Срок действия студенческого</th>
                    <th>Отчёты</th>
                </tr>
            </thead>
            <tbody>
                <!-- Data will be displayed here -->
                <tr>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                    <td>...</td>
                </tr>
                <!-- Add more rows here -->
            </tbody>
        </table>
    </div>
    <div class="pagination">
        <p>Страница 1 из 2400</p>
        <p>15 элементов на странице</p>
        <p>Отображены записи 1-15 из 35991</p>
        <button>+ Добавить</button>
        <button>Подтверждение достоверности</button>
        <button>Наличие согласия</button>
        <button>Данных</button>
    </div>
</body>
</html>
