以上程式由 Visual Studio  進行開發，主要是練習程式用的，皆附有Demo，但JX3_AuxiliarySystem 會依賴於遊戲，但是台灣伺服器已關閉，故以下皆為示意圖。

# JX3_AuxiliarySystem：
網路遊戲 - 劍俠情緣 3 online的輔助程式，該遊戲有個很有趣的玩法，是由25個玩家組成的隊伍，發揮各門派的特色一起對抗 BOSS。 而對抗過程中需要隊長進行調度，像是02:30秒 Boss 會使出一招，需要某個職業打出特殊技能才能幫大家度過這次災難。

1. 所以身為隊長必須根據各種場景來提醒，於是該程式會自動判斷 時間、團隊血量、Boss 血量、Boss 對話等等 進行圖像處理，以此得到對應的數據，之後給予倒數時間條提示對應的行為。
![](https://i.imgur.com/nSYkJJX.jpg)
2. 該遊戲有個科舉活動，於周末舉辦出題答題的活動，而科舉題目多半為文言文或歷史人物傳記，深澀難懂，所以多數人都是利用網路上的文章搜尋這題答案，此輔助程式可以根據資料庫和影像處理直接提示該題答案為何，無須在上網搜尋答案。
![](https://i.imgur.com/0rxXlHX.png)
1.  該遊戲有個神農日常，可以於特定地方採集藥材，而藥材採集通常都需要人工按下採集按鈕後進行採集，之後根據神農系統提示最近的草藥點在哪，之後自動尋路移動過去，該程式可以自動按下採集按鈕並且根據圖形處理點集自動尋路功能。(實作按鈕部分請參考 Keyboard Mouse Mange 程式)
2.  每個人的影像處裡資料庫都可採樣，並可以自動把資料庫至於雲端 ( 個人 MEGA，一天最多8GB上傳下載 )上，還可以選擇同步當前最新版所有人的資料庫集合。
![](https://i.imgur.com/vyifKoB.png)


# Keyboard Mouse Mange：
為了實現 JX3_AuxiliarySystem 的自動按下某個按鈕的實作Demo，並且提供更簡單操作的API，主要因為Windows的API太難操作，必須時刻去搜尋Windows上各裝置的Guid還有API使用的16進制代號等等，就是要一直查表，所以此處對於此類操作進行封裝。
1. 可以偵測滑鼠的移動位置、上滾、下滾、滾輪中鍵、左鍵、右鍵等等功能。
2. 可以偵測鍵盤任意按鈕 按下、 放開、按著等等功能。
![](https://i.imgur.com/M4lbU8F.png)
3. 可以錄製一段滑鼠和鍵盤的操作，之後播放這個錄製操作。
![](https://i.imgur.com/cuA8QcP.png)

# WiFi ShowNetwork：
WiFi API，此工具為舊公司當時需要時做WiFi項目的檢測，但是Windows的WiFi Command Api 會因為語系而產生亂碼，而網路上其他人的API又經常有問題，機率性發生在特定裝置。所以離職後痛定思痛，就決定自己寫了個操作WiFi的API工具，該工具是直接操作Windows的API，必須查表、各函數的16進制、處理C++與C#溝通的相異等等，以此手段操作Wifi，並封裝成dll檔案供他人使用。

1. 可以偵測該電腦的所有無線網卡、並選擇該網卡進行操作
![](https://i.imgur.com/OBw7hS6.png)

2. 可以偵測使用該網卡下，周圍所有WiFi熱點的詳細資訊
![](https://i.imgur.com/PnOw22l.png)

3. 可以使用該網卡對某熱點進行連線，並且有 重新輸入密碼和使用該電腦的記憶密碼功能 來進行連線憑證。

# Word Book：
本人英文不好，所以寫了個單字本工具進行學習英文單字，在 JX3_AuxiliarySystem 雲端採用MEGA方案其實不是首選，當初首選是Google 硬碟，但是Google API 都要錢 還很貴，所以放棄該方案採用廉價的MEGA，在這過程中發現 翻譯API是不用錢的，可能跟翻譯網站的資料傳輸方式有關。

1. 此處採用Google 翻譯 URL 將 英文 翻譯成 中文，並且朗誦一次英文發音，並選擇是否要儲存這次結果至「單字寶典」
![](https://i.imgur.com/XHikncd.png)
2. 可以根據「單字寶典」進行單字測試。
![](https://i.imgur.com/ycqc5cc.png)
3. 可以根據測試結果提供一份你當前測試結果如何？哪個單字的答對率最高、哪個單字的答錯率最低。
![](https://i.imgur.com/ll9VlIH.png)