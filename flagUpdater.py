try:
    from bs4 import BeautifulSoup
except Exception as e:
    print("Не могу найти библиотеку BeautifulSoup4, а она для работы очень нужна")
    input("Нажмите Enter для выхода...")
    exit()
try:
    import requests
except Exception as e:
    print("Не могу найти библиотеку requests, а она для работы очень нужна")
    input("Нажмите Enter для выхода...")
    exit()

url_flags = 'https://www.countries-ofthe-world.com/'
headers_flags = {'User-Agent': 'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36'}
try:
    page_flags = requests.get(url_flags + 'flags-of-the-world.html', headers=headers_flags)
except Exception as e:
    print("Упс, не могу подключиться к сайту с флагами. Проверьте подключение к сети (скорее всего проблема в этом, но это не точно")
    input("Нажмите Enter для выхода...")
    exit()

soup_flags = BeautifulSoup(page_flags.text, "lxml")  # Making html 'soup' from raw text with lxml html parser
table1, table2 = soup_flags.find_all('table', class_='two-column td-image')

url_names = 'https://en.wikipedia.org/wiki/List_of_IOC_country_codes'
try:
    page_names = requests.get(url_names, headers=headers_flags)
except Exception as e:
    print("Упс, не могу подключиться к Википедии. Проверьте подключение к сети (скорее всего проблема в этом, но это не точно")
    input("Нажмите Enter для выхода...")
    exit()
page_names = requests.get(url_names, headers=headers_flags)
soup_names = BeautifulSoup(page_names.text, 'lxml')
names = {}

table_names = soup_names.find('table')

for tr in table_names.find_all('tr'):
    tds = tr.find_all('td')
    if tds == []:
        continue
    name, shortname = tds[2].a.text, tds[0].text
    names[name] = shortname
notFound = []
i = 0
for tr in table1.find_all('tr'):
    if tr.td == None:
        continue
    if tr.td.img == None:
        continue
    if tr.get('class') == 'line':
        continue
    image, name = tr.find_all('td')
    image = requests.get(url_flags + image.img.get('src'))
    name = name.text
    try:
        shortname = names[name]
    except KeyError:
        notFound.append(name)
        continue
    with open('Flags/' + names[name] + '.png', 'wb') as f:
        i += 1
        print("%.2f" % (i / len(names) * 100), '%', sep='')
        f.write(image.content)
        f.close()
for tr in table2.find_all('tr'):
    if tr.td == None:
        continue
    if tr.td.img == None:
        continue
    if tr.get('class') == 'line':
        continue
    image, name = tr.find_all('td')
    image = requests.get(url_flags + image.img.get('src'))
    name = name.text
    try:
        shortname = names[name]
    except KeyError:
        notFound.append(name)
        continue
    with open('flags/' + names[name] + '.png', 'wb') as f:
        i += 1
        print("%.2f" % (i / len(names) * 100), '\%', sep='')
        f.write(image.content)
        f.close()

print('Страны, флаги которых не были обновлены:')
for x in notFound:
    print(x)
input("Нажмите Enter для продолжения...")
