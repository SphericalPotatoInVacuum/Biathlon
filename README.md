# Биатлон
Проект лежит в сжатой папке Bogdanov.zip, всё остальное - исходный код

Для начала работы нажмите кнопку "Начать". Откроется окно с серым прямоугольником и кнопками. Чтобы загрузить файл с данными в приложение, нажмите кнопку "Выбрать файл". 
Если файл был считан удачно, то в окошке под кнопкой появится имя файла. 
Если оно не влезает в окошко, то будет прокручиваться влево-вправо.

В правой нижней части есть область с различными фильтрами, применяемыми к таблице.

Если Вы хотите увидеть только участников одной страны, то укажите в поле первого сверху фильтра IOC код этой страны, или оставьте поле пустым для отключения фильтра.

Если Вы хотите увидеть только определённое число участников, укажите это число во втором фильтре, или поставьте 0 для отключения фильтра.

С помощью третьего фильтра можно установить порядок, в котором участники будут отображаться в таблице.
Если выбран тип сортировки "В порядке занятых мест", то участники будут отсортированы по возрастанию по номерам с учётом штрафов, в этом случае для каждого участника будет отображаться его отставание от лидера, а для лидера - время финиша + штраф.
Если выбрана сортировка по скорости, то штрафное время учитываться не будет, и для каждого участника будет отображаться время его финиша.
Если выбрана сортировка по меткости, то участники будут отсортированы по возрастанию по количеству промахов, если же оно равно, то по времени с учётом штрафов. Отображение времени такое же, как и в сортировке по занятому месту.

Обновить базу данных флагов можно нажав в пределах формы правую кнопку мыши и в выпавшем меню выбрать пункт "Обновить флаги" (Он там один)
Откроется окно командной строки, в котором, если у Вас на компьютере есть Python 3.x (с библиотеками BeautifulSoup4 и requests) и интернет, запустится скрипт выкачивания флагов с открытых источников и IOC кодов стран с Википедии (под которыми флаги сохраняются в папке Flags).

Каждое окно можно перетаскивать, растягивать и сжимать, а также раздвигать на весь экран нажатием соответствующей кнопки или двойным кликом по серой области вверху окна.
