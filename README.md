# 02-prefabs-triggers
א.שינוי ושיפור המשחק מהשיעור
שינויים: השחקן לא יכול לירות בלייזרים בלי הפסקה, אלא חייב לחכות זמן מסויים- חצי שנייה בין יריה ליריה הבאה
PlayerSpaseship --->LasterShoter(Script)--->
ירושה 
-----> class KeybordSpawner---->duration (time value)= 0.5f ----> function Update() ...if(...timer>duration)... timer=0;--->
יריות ---> כפתור רווח
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ב. מימוש גבולות
עולם שטוח עם גבולות גלויים, קירות שאי אפשר לעבור
Player----> RigingBody+CapsuleCollider ---> Drag=0---->PlayerControl(Script) ---->... (.MovePosition())
תזוזה של השחקן עם החצים. 
     ^
     |
<--------->
     |
     V
  4 קירות---->BoxCollider+RigingBody----> Drag=5;
  
 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
   עולם שטוח עם גבולות בלתי נראים.השחקן והאויב לא יכולים לחצות את הגבול. האויב מגיעה לגבול ולא יכול לעבור אותו ואם הוא מתנגש באויב השני- שניהם נעלמים
  השחקן צריך להיזהר לא להתנגש באויב אחרת שניהם נהרסים
  Player----> StayInside(Script)
  שימוש בפונקציה מתמטית
  Math.Calmp(מיקום,min,max)
  
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  עולם עגול
  PlayerSpaceShip----> StayInside(Script)-----> JumpObject(Script)
  
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  
  Tetris racing-
  השחקן הוא מכונית והוא צריך להיזהר לא להתנגש במכוניות שמגיעות מכיוון השני
  PlayerCar----> Tag=Player----> MyKeybordMover(Script) ----> תזוזה לפי ציר x 
  <----->
  Rigidbody2d-Kinematic+BoxCollider2d----> isTrigger
  DestroyOnTrigger2d(Script)---->Triggering Tag =Enemy
  השחקן הורג את Enemy
  
  
  
  
  Cars----->Tag=Enemy----> TimeSpawnerRandome(Script)--->prefabs--->cars(mover)---->Mover(Script)
  Boxcollider2d+Rigidbody2d---->Kinematic---->DestroyOnTrigger2d(script)
   הורג את ה Player
  
  
  
  
