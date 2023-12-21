**YearbookBoard - לוח שנתון**

**Description :** מערכת לניהול פרטים ועדכונים בשנתון

**Entities - ישויות**

- *TelephoneBoardController - לוח טלפונים*

- *EventsController - רשימת אירועים*

- *UpdatesController - רשימת עדכונים והודעות*

**Entities detail - פירוט הישויות**

*TelephoneBoardController - לוח טלפונים*

- GET: [https://YearbookBoard.co.il/TelephoneBoard](https://YearbookBoard.co.il/telephone-boards) - מחזיר את כל לוחות הטלפון

- GET: [https://YearbookBoard.co.il/TelephoneBoard{id}](https://YearbookBoard.co.il/telephone-boards/{id}) - מחזיר את לוח הטלפון לפי מזהה

- POST: [https://YearbookBoard.co.il/TelephoneBoard](https://YearbookBoard.co.il/telephone-boards) - יוצר לוח טלפון חדש

- PUT: [https://YearbookBoard.co.il/TelephoneBoard{id}](https://YearbookBoard.co.il/telephone-boards/{id}) - מעדכן לוח טלפון קיים

- DELETE: [https://YearbookBoard.co.il/TelephoneBoard{id}](https://YearbookBoard.co.il/telephone-boards/{id}) - מוחק לוח טלפון קיים

*EventsController - רשימת אירועים*

- GET: [https://YearbookBoard.co.il/Events](https://YearbookBoard.co.il/events) - מחזיר את כל האירועים

- GET: [https://YearbookBoard.co.il/Events{id}](https://YearbookBoard.co.il/events/{id}) - מחזיר את האירוע לפי מזהה

- POST: [https://YearbookBoard.co.il/Events](https://YearbookBoard.co.il/events) - יוצר אירוע חדש

- PUT: [https://YearbookBoard.co.il/Events{id}](https://YearbookBoard.co.il/events/{id}) - מעדכן אירוע קיים

- DELETE: [https://YearbookBoard.co.il/Events{id}](https://YearbookBoard.co.il/events/{id}) - מוחק אירוע קיים

*UpdatesController - רשימת עדכונים והודעות*

- GET: [https://YearbookBoard.co.il/Updates](https://YearbookBoard.co.il/updates) - מחזיר את כל העידכונים

- GET: [https://YearbookBoard.co.il/Updates{id}](https://YearbookBoard.co.il/updates/{id}) - מחזיר את העדכון לפי מזהה

- POST: [https://YearbookBoard.co.il/Updates](https://YearbookBoard.co.il/updates) - יוצר עדכון חדש

- PUT: [https://YearbookBoard.co.il/Updates{id}](https://YearbookBoard.co.il/updates/{id}) - מעדכן עדכון קיים

- DELETE: [https://YearbookBoard.co.il/Updates{id}](https://YearbookBoard.co.il/updates/{id}) - מוחק עדכון קיים
