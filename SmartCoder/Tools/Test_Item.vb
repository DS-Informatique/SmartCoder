Imports System.Windows.Forms
Imports System.Drawing
Public Class Test_Item

    Private _Language As Enum_Langue
    Public Property Language() As Enum_Langue
        Get
            Return _Language
        End Get
        Set(ByVal value As Enum_Langue)
#Region "<Prepare Language>"

            If ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Arabic Then
#Region "<Arabic>"
                Dock_Property.Text = "خاصية"
                Dock_Tree.Text = "شجرة"
                Dock_ResultSummary.Text = "النتائج"
                Dock_Information.Text = "معلومات"
                Dock_Map.Text = "خريطة"
                Dock_Resultats.Text = "النتائج"
                Dock_Web.Text = "شبكة"
                L_Pass.Text = "البشري"
                L_Fail.Text = "فشل"
                L_Erreur.Text = "أخطاء"
                L_Nul.Text = "بدون نتائج"
                L_Load.Text = "حمل"
                SuperTabItem1.Text = "تحليل"
                SuperTabItem2.Text = "فرضية"
                SuperTabItem3.Text = "المتغيرات"
                SuperTabItem4.Text = "النتائج"
                SuperTabItem6.Text = "دليل"
                SuperTabItem16.Text = "الجسم"
                SuperTabItem20.Text = "إدخال"
                SuperTabItem23.Text = "انتاج |"
                SuperTabItem26.Text = "جزء"
                SuperTabItem21.Text = "خيط"
                SuperTabItem22.Text = "خاصية"
                SuperTabItem24.Text = "خيط"
                SuperTabItem25.Text = "خاصية"
                SuperTabItem5.Text = "القوائم"
                SuperTabItem7.Text = "فشل قائمة"
                SuperTabItem8.Text = "قائمة النجاح"
                SuperTabItem9.Text = "قائمة التحذير"
                SuperTabItem10.Text = "قائمة Null"
                SuperTabItem15.Text = "معلومات"
                SuperTabItem12.Text = "خطوات"
                SuperTabItem13.Text = "استثناءات"
                SuperTabItem14.Text = "المتغيرات"
                Btn_Show_Information.Text = "قائمة طعام"
                Node1.Text = "[تحليل]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.English Then
#Region "<English>"
                Dock_Property.Text = "Property"
                Dock_Tree.Text = "Tree"
                Dock_ResultSummary.Text = "Results"
                Dock_Information.Text = "Information"
                Dock_Map.Text = "Map"
                Dock_Resultats.Text = "Results"
                Dock_Web.Text = "Web"
                L_Pass.Text = "Pass"
                L_Fail.Text = "fail"
                L_Erreur.Text = "errors"
                L_Nul.Text = "Without results"
                L_Load.Text = "Load"
                SuperTabItem1.Text = "Analysis"
                SuperTabItem2.Text = "Hypothesis"
                SuperTabItem3.Text = "variables"
                SuperTabItem4.Text = "Results"
                SuperTabItem6.Text = "Evidence"
                SuperTabItem16.Text = "Body"
                SuperTabItem20.Text = "Input"
                SuperTabItem23.Text = "Output"
                SuperTabItem26.Text = "Element"
                SuperTabItem21.Text = "String"
                SuperTabItem22.Text = "Property"
                SuperTabItem24.Text = "String"
                SuperTabItem25.Text = "Property"
                SuperTabItem5.Text = "lists"
                SuperTabItem7.Text = "Failed List"
                SuperTabItem8.Text = "Success list"
                SuperTabItem9.Text = "Warning List"
                SuperTabItem10.Text = "List Null"
                SuperTabItem15.Text = "Information"
                SuperTabItem12.Text = "Steps"
                SuperTabItem13.Text = "exceptions"
                SuperTabItem14.Text = "variables"
                Btn_Show_Information.Text = "Menu"
                Node1.Text = "[Analysis]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Français Then
#Region "<Français>"
                Dock_Property.Text = "Propriété"
                Dock_Tree.Text = "Arbre"
                Dock_ResultSummary.Text = "Résultats"
                Dock_Information.Text = "Information"
                Dock_Map.Text = "Carte"
                Dock_Resultats.Text = "Résultats"
                Dock_Web.Text = "Web"
                L_Pass.Text = "Passer"
                L_Fail.Text = "échouer"
                L_Erreur.Text = "les erreurs"
                L_Nul.Text = "Sans résultats"
                L_Load.Text = "Charge"
                SuperTabItem1.Text = "Une analyse"
                SuperTabItem2.Text = "Hypothèse"
                SuperTabItem3.Text = "les variables"
                SuperTabItem4.Text = "Résultats"
                SuperTabItem6.Text = "Preuve"
                SuperTabItem16.Text = "Corps"
                SuperTabItem20.Text = "Contribution"
                SuperTabItem23.Text = "Sortie"
                SuperTabItem26.Text = "Élément"
                SuperTabItem21.Text = "Chaîne"
                SuperTabItem22.Text = "Propriété"
                SuperTabItem24.Text = "Chaîne"
                SuperTabItem25.Text = "Propriété"
                SuperTabItem5.Text = "des listes"
                SuperTabItem7.Text = "Liste échouée"
                SuperTabItem8.Text = "Liste de réussite"
                SuperTabItem9.Text = "Liste d'avertissement"
                SuperTabItem10.Text = "Liste Null"
                SuperTabItem15.Text = "Information"
                SuperTabItem12.Text = "Pas"
                SuperTabItem13.Text = "des exceptions"
                SuperTabItem14.Text = "les variables"
                Btn_Show_Information.Text = "Menu"
                Node1.Text = "[Une analyse]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Italian Then
#Region "<Italian>"
                Dock_Property.Text = "Proprietà"
                Dock_Tree.Text = "Albero"
                Dock_ResultSummary.Text = "risultati"
                Dock_Information.Text = "Informazione"
                Dock_Map.Text = "Carta geografica"
                Dock_Resultats.Text = "risultati"
                Dock_Web.Text = "web"
                L_Pass.Text = "Passaggio"
                L_Fail.Text = "fallire"
                L_Erreur.Text = "errori"
                L_Nul.Text = "Senza risultati"
                L_Load.Text = "Caricare"
                SuperTabItem1.Text = "Analisi"
                SuperTabItem2.Text = "Ipotesi"
                SuperTabItem3.Text = "variabili"
                SuperTabItem4.Text = "risultati"
                SuperTabItem6.Text = "Prova"
                SuperTabItem16.Text = "Corpo"
                SuperTabItem20.Text = "Ingresso"
                SuperTabItem23.Text = "Produzione"
                SuperTabItem26.Text = "Elemento"
                SuperTabItem21.Text = "Stringa"
                SuperTabItem22.Text = "Proprietà"
                SuperTabItem24.Text = "Stringa"
                SuperTabItem25.Text = "Proprietà"
                SuperTabItem5.Text = "liste"
                SuperTabItem7.Text = "Elenco non funzionante"
                SuperTabItem8.Text = "Lista di successo"
                SuperTabItem9.Text = "Lista di avvertimento"
                SuperTabItem10.Text = "Elenco Nullo"
                SuperTabItem15.Text = "Informazione"
                SuperTabItem12.Text = "passi"
                SuperTabItem13.Text = "eccezioni"
                SuperTabItem14.Text = "variabili"
                Btn_Show_Information.Text = "Menu"
                Node1.Text = "[Analisi]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.German Then
#Region "<German>"
                Dock_Property.Text = "Eigentum"
                Dock_Tree.Text = "Baum"
                Dock_ResultSummary.Text = "Ergebnisse"
                Dock_Information.Text = "Information"
                Dock_Map.Text = "Karte"
                Dock_Resultats.Text = "Ergebnisse"
                Dock_Web.Text = "Netz"
                L_Pass.Text = "Bestehen"
                L_Fail.Text = "Scheitern"
                L_Erreur.Text = "Fehler"
                L_Nul.Text = "Ohne Ergebnisse"
                L_Load.Text = "Belastung"
                SuperTabItem1.Text = "Analyse"
                SuperTabItem2.Text = "Hypothese"
                SuperTabItem3.Text = "Variablen"
                SuperTabItem4.Text = "Ergebnisse"
                SuperTabItem6.Text = "Beweise"
                SuperTabItem16.Text = "Karosserie"
                SuperTabItem20.Text = "Eingang"
                SuperTabItem23.Text = "Ausgabe"
                SuperTabItem26.Text = "Element"
                SuperTabItem21.Text = "Zeichenfolge"
                SuperTabItem22.Text = "Eigentum"
                SuperTabItem24.Text = "Zeichenfolge"
                SuperTabItem25.Text = "Eigentum"
                SuperTabItem5.Text = "Listen"
                SuperTabItem7.Text = "Fehlgeschlagene Liste"
                SuperTabItem8.Text = "Erfolgsliste"
                SuperTabItem9.Text = "Warnungsliste"
                SuperTabItem10.Text = "Liste Null"
                SuperTabItem15.Text = "Information"
                SuperTabItem12.Text = "Schritte"
                SuperTabItem13.Text = "Ausnahmen"
                SuperTabItem14.Text = "Variablen"
                Btn_Show_Information.Text = "Speisekarte"
                Node1.Text = "[Analyse]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Spanish Then
#Region "<Spanish>"
                Dock_Property.Text = "Propiedad"
                Dock_Tree.Text = "Árbol"
                Dock_ResultSummary.Text = "Resultados"
                Dock_Information.Text = "Información"
                Dock_Map.Text = "Mapa"
                Dock_Resultats.Text = "Resultados"
                Dock_Web.Text = "Web"
                L_Pass.Text = "Pasar"
                L_Fail.Text = "fallar"
                L_Erreur.Text = "errores"
                L_Nul.Text = "Sin resultados"
                L_Load.Text = "Carga"
                SuperTabItem1.Text = "Análisis"
                SuperTabItem2.Text = "Hipótesis"
                SuperTabItem3.Text = "variables"
                SuperTabItem4.Text = "Resultados"
                SuperTabItem6.Text = "Evidencia"
                SuperTabItem16.Text = "Cuerpo"
                SuperTabItem20.Text = "Entrada"
                SuperTabItem23.Text = "Salida"
                SuperTabItem26.Text = "Elemento"
                SuperTabItem21.Text = "Cuerda"
                SuperTabItem22.Text = "Propiedad"
                SuperTabItem24.Text = "Cuerda"
                SuperTabItem25.Text = "Propiedad"
                SuperTabItem5.Text = "liza"
                SuperTabItem7.Text = "Lista fallida"
                SuperTabItem8.Text = "Lista de éxitos"
                SuperTabItem9.Text = "Lista de advertencia"
                SuperTabItem10.Text = "Lista Null"
                SuperTabItem15.Text = "Información"
                SuperTabItem12.Text = "Pasos"
                SuperTabItem13.Text = "excepciones"
                SuperTabItem14.Text = "variables"
                Btn_Show_Information.Text = "Menú"
                Node1.Text = "[Análisis]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Hebrew Then
#Region "<Hebrew>"
                Dock_Property.Text = "נכס"
                Dock_Tree.Text = "עֵץ"
                Dock_ResultSummary.Text = "תוצאות"
                Dock_Information.Text = "מֵידָע"
                Dock_Map.Text = "מַפָּה"
                Dock_Resultats.Text = "תוצאות"
                Dock_Web.Text = "אינטרנט"
                L_Pass.Text = "לַעֲבוֹר"
                L_Fail.Text = "לְהִכָּשֵׁל"
                L_Erreur.Text = "שגיאות"
                L_Nul.Text = "ללא תוצאות"
                L_Load.Text = "לִטעוֹן"
                SuperTabItem1.Text = "אָנָלִיזָה"
                SuperTabItem2.Text = "הַשׁעָרָה"
                SuperTabItem3.Text = "משתנים"
                SuperTabItem4.Text = "תוצאות"
                SuperTabItem6.Text = "עֵדוּת"
                SuperTabItem16.Text = "גוּף"
                SuperTabItem20.Text = "קֶלֶט"
                SuperTabItem23.Text = "תְפוּקָה"
                SuperTabItem26.Text = "אֵלֵמֶנט"
                SuperTabItem21.Text = "חוּט"
                SuperTabItem22.Text = "נכס"
                SuperTabItem24.Text = "חוּט"
                SuperTabItem25.Text = "נכס"
                SuperTabItem5.Text = "רשימות"
                SuperTabItem7.Text = "רשימת נכשלה"
                SuperTabItem8.Text = "רשימת ההצלחה"
                SuperTabItem9.Text = "רשימת אזהרה"
                SuperTabItem10.Text = "רשימה Null"
                SuperTabItem15.Text = "מֵידָע"
                SuperTabItem12.Text = "צעדים"
                SuperTabItem13.Text = "חריגים"
                SuperTabItem14.Text = "משתנים"
                Btn_Show_Information.Text = "תַפרִיט"
                Node1.Text = "[אָנָלִיזָה]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Portuguese Then
#Region "<Portuguese>"
                Dock_Property.Text = "Propriedade"
                Dock_Tree.Text = "Árvore"
                Dock_ResultSummary.Text = "Resultados"
                Dock_Information.Text = "Em formação"
                Dock_Map.Text = "Mapa"
                Dock_Resultats.Text = "Resultados"
                Dock_Web.Text = "Rede"
                L_Pass.Text = "Passar"
                L_Fail.Text = "falhou"
                L_Erreur.Text = "erros"
                L_Nul.Text = "Sem resultados"
                L_Load.Text = "Carga"
                SuperTabItem1.Text = "Análise"
                SuperTabItem2.Text = "Hipótese"
                SuperTabItem3.Text = "variáveis"
                SuperTabItem4.Text = "Resultados"
                SuperTabItem6.Text = "Evidência"
                SuperTabItem16.Text = "Corpo"
                SuperTabItem20.Text = "Entrada"
                SuperTabItem23.Text = "Saída"
                SuperTabItem26.Text = "Elemento"
                SuperTabItem21.Text = "Corda"
                SuperTabItem22.Text = "Propriedade"
                SuperTabItem24.Text = "Corda"
                SuperTabItem25.Text = "Propriedade"
                SuperTabItem5.Text = "listas"
                SuperTabItem7.Text = "Lista falhada"
                SuperTabItem8.Text = "Lista de sucesso"
                SuperTabItem9.Text = "Lista de avisos"
                SuperTabItem10.Text = "Listar Nulo"
                SuperTabItem15.Text = "Em formação"
                SuperTabItem12.Text = "Passos"
                SuperTabItem13.Text = "exceções"
                SuperTabItem14.Text = "variáveis"
                Btn_Show_Information.Text = "Cardápio"
                Node1.Text = "[Análise]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Russian Then
#Region "<Russian>"
                Dock_Property.Text = "Имущество"
                Dock_Tree.Text = "дерево"
                Dock_ResultSummary.Text = "Результаты"
                Dock_Information.Text = "Информация"
                Dock_Map.Text = "карта"
                Dock_Resultats.Text = "Результаты"
                Dock_Web.Text = "Web"
                L_Pass.Text = "Проходить"
                L_Fail.Text = "потерпеть неудачу"
                L_Erreur.Text = "ошибки"
                L_Nul.Text = "Без результатов"
                L_Load.Text = "нагрузка"
                SuperTabItem1.Text = "Анализ"
                SuperTabItem2.Text = "гипотеза"
                SuperTabItem3.Text = "переменные"
                SuperTabItem4.Text = "Результаты"
                SuperTabItem6.Text = "Доказательства"
                SuperTabItem16.Text = "тело"
                SuperTabItem20.Text = "вход"
                SuperTabItem23.Text = "Вывод"
                SuperTabItem26.Text = "Элемент"
                SuperTabItem21.Text = "строка"
                SuperTabItem22.Text = "Имущество"
                SuperTabItem24.Text = "строка"
                SuperTabItem25.Text = "Имущество"
                SuperTabItem5.Text = "списки"
                SuperTabItem7.Text = "Сбой списка"
                SuperTabItem8.Text = "Список успехов"
                SuperTabItem9.Text = "Список предупреждений"
                SuperTabItem10.Text = "Список Null"
                SuperTabItem15.Text = "Информация"
                SuperTabItem12.Text = "меры"
                SuperTabItem13.Text = "исключения"
                SuperTabItem14.Text = "переменные"
                Btn_Show_Information.Text = "Меню"
                Node1.Text = "[Анализ]"
#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Chinese Then
#Region "<Chinese>"
                Dock_Property.Text = "屬性"
                Dock_Tree.Text = "樹"
                Dock_ResultSummary.Text = "結果"
                Dock_Information.Text = "信息"
                Dock_Map.Text = "地圖"
                Dock_Resultats.Text = "結果"
                Dock_Web.Text = "捲筒紙"
                L_Pass.Text = "通過"
                L_Fail.Text = "失敗"
                L_Erreur.Text = "錯誤"
                L_Nul.Text = "沒有結果"
                L_Load.Text = "加載"
                SuperTabItem1.Text = "分析"
                SuperTabItem2.Text = "假設"
                SuperTabItem3.Text = "變量"
                SuperTabItem4.Text = "結果"
                SuperTabItem6.Text = "證據"
                SuperTabItem16.Text = "身體"
                SuperTabItem20.Text = "輸入"
                SuperTabItem23.Text = "產量"
                SuperTabItem26.Text = "元件"
                SuperTabItem21.Text = "串"
                SuperTabItem22.Text = "屬性"
                SuperTabItem24.Text = "串"
                SuperTabItem25.Text = "屬性"
                SuperTabItem5.Text = "名單"
                SuperTabItem7.Text = "失敗的名單"
                SuperTabItem8.Text = "成功名單"
                SuperTabItem9.Text = "警告清單"
                SuperTabItem10.Text = "列表空"
                SuperTabItem15.Text = "信息"
                SuperTabItem12.Text = "腳步"
                SuperTabItem13.Text = "例外"
                SuperTabItem14.Text = "變量"
                Btn_Show_Information.Text = "菜單"
                Node1.Text = "[分析]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Greek Then
#Region "<Greek>"
                Dock_Property.Text = "Ιδιοκτησία"
                Dock_Tree.Text = "Δέντρο"
                Dock_ResultSummary.Text = "Αποτελέσματα"
                Dock_Information.Text = "Πληροφορίες"
                Dock_Map.Text = "Χάρτης"
                Dock_Resultats.Text = "Αποτελέσματα"
                Dock_Web.Text = "Ιστός"
                L_Pass.Text = "Πέρασμα"
                L_Fail.Text = "αποτυγχάνω"
                L_Erreur.Text = "σφάλματα"
                L_Nul.Text = "Χωρίς αποτελέσματα"
                L_Load.Text = "Φορτώνω"
                SuperTabItem1.Text = "Ανάλυση"
                SuperTabItem2.Text = "Υπόθεση"
                SuperTabItem3.Text = "μεταβλητές"
                SuperTabItem4.Text = "Αποτελέσματα"
                SuperTabItem6.Text = "Απόδειξη"
                SuperTabItem16.Text = "Σώμα"
                SuperTabItem20.Text = "Εισαγωγή"
                SuperTabItem23.Text = "Παραγωγή"
                SuperTabItem26.Text = "Στοιχείο"
                SuperTabItem21.Text = "Σειρά"
                SuperTabItem22.Text = "Ιδιοκτησία"
                SuperTabItem24.Text = "Σειρά"
                SuperTabItem25.Text = "Ιδιοκτησία"
                SuperTabItem5.Text = "τόπος αγώνων"
                SuperTabItem7.Text = "Αποτυχημένη λίστα"
                SuperTabItem8.Text = "Λίστα επιτυχίας"
                SuperTabItem9.Text = "Λίστα προειδοποιήσεων"
                SuperTabItem10.Text = "Λίστα Null"
                SuperTabItem15.Text = "Πληροφορίες"
                SuperTabItem12.Text = "Βήματα"
                SuperTabItem13.Text = "εξαιρέσεις"
                SuperTabItem14.Text = "μεταβλητές"
                Btn_Show_Information.Text = "Μενού"
                Node1.Text = "[Ανάλυση]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Japanese Then
#Region "<Japanese>"
                Dock_Property.Text = "プロパティ"
                Dock_Tree.Text = "木"
                Dock_ResultSummary.Text = "結果"
                Dock_Information.Text = "情報"
                Dock_Map.Text = "地図"
                Dock_Resultats.Text = "結果"
                Dock_Web.Text = "ウェブ"
                L_Pass.Text = "パス"
                L_Fail.Text = "失敗します"
                L_Erreur.Text = "エラー"
                L_Nul.Text = "結果なし"
                L_Load.Text = "負荷"
                SuperTabItem1.Text = "分析"
                SuperTabItem2.Text = "仮説"
                SuperTabItem3.Text = "変数"
                SuperTabItem4.Text = "結果"
                SuperTabItem6.Text = "証拠"
                SuperTabItem16.Text = "体"
                SuperTabItem20.Text = "入力"
                SuperTabItem23.Text = "出力"
                SuperTabItem26.Text = "素子"
                SuperTabItem21.Text = "文字列"
                SuperTabItem22.Text = "プロパティ"
                SuperTabItem24.Text = "文字列"
                SuperTabItem25.Text = "プロパティ"
                SuperTabItem5.Text = "リスト"
                SuperTabItem7.Text = "失敗したリスト"
                SuperTabItem8.Text = "成功リスト"
                SuperTabItem9.Text = "警告リスト"
                SuperTabItem10.Text = "ヌルリスト"
                SuperTabItem15.Text = "情報"
                SuperTabItem12.Text = "ステップ"
                SuperTabItem13.Text = "例外"
                SuperTabItem14.Text = "変数"
                Btn_Show_Information.Text = "メニュー"
                Node1.Text = "[分析]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Latin Then
#Region "<Latin>"
                Dock_Property.Text = "possessionem"
                Dock_Tree.Text = "lignum"
                Dock_ResultSummary.Text = "results"
                Dock_Information.Text = "notitia"
                Dock_Map.Text = "map"
                Dock_Resultats.Text = "results"
                Dock_Web.Text = "Web"
                L_Pass.Text = "expendas"
                L_Fail.Text = "deficient"
                L_Erreur.Text = "erroribus"
                L_Nul.Text = "fructu efficitur"
                L_Load.Text = "onus"
                SuperTabItem1.Text = "in analysis"
                SuperTabItem2.Text = "hypothesi"
                SuperTabItem3.Text = "variables"
                SuperTabItem4.Text = "results"
                SuperTabItem6.Text = "quod"
                SuperTabItem16.Text = "corporis"
                SuperTabItem20.Text = "conlationem"
                SuperTabItem23.Text = "exitus"
                SuperTabItem26.Text = "elementum"
                SuperTabItem21.Text = "torque"
                SuperTabItem22.Text = "possessionem"
                SuperTabItem24.Text = "torque"
                SuperTabItem25.Text = "possessionem"
                SuperTabItem5.Text = "lists"
                SuperTabItem7.Text = "defecit album"
                SuperTabItem8.Text = "Index victoria"
                SuperTabItem9.Text = "monitum List"
                SuperTabItem10.Text = "nullum album"
                SuperTabItem15.Text = "notitia"
                SuperTabItem12.Text = "non"
                SuperTabItem13.Text = "dictarum excepcionium"
                SuperTabItem14.Text = "variables"
                Btn_Show_Information.Text = "menu"
                Node1.Text = "[Analysis]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Thai Then
#Region "<Thai>"
                Dock_Property.Text = "คุณสมบัติ"
                Dock_Tree.Text = "ต้นไม้"
                Dock_ResultSummary.Text = "ผล"
                Dock_Information.Text = "ข้อมูล"
                Dock_Map.Text = "แผนที่"
                Dock_Resultats.Text = "ผล"
                Dock_Web.Text = "เว็บ"
                L_Pass.Text = "ผ่าน"
                L_Fail.Text = "ล้มเหลว"
                L_Erreur.Text = "ข้อผิดพลาด"
                L_Nul.Text = "ไม่มีผลลัพธ์"
                L_Load.Text = "ภาระ"
                SuperTabItem1.Text = "การวิเคราะห์"
                SuperTabItem2.Text = "สมมติฐาน"
                SuperTabItem3.Text = "ตัวแปร"
                SuperTabItem4.Text = "ผล"
                SuperTabItem6.Text = "หลักฐาน"
                SuperTabItem16.Text = "ร่างกาย"
                SuperTabItem20.Text = "อินพุต"
                SuperTabItem23.Text = "เอาท์พุต"
                SuperTabItem26.Text = "ธาตุ"
                SuperTabItem21.Text = "เชือก"
                SuperTabItem22.Text = "คุณสมบัติ"
                SuperTabItem24.Text = "เชือก"
                SuperTabItem25.Text = "คุณสมบัติ"
                SuperTabItem5.Text = "รายการ"
                SuperTabItem7.Text = "รายการที่ล้มเหลว"
                SuperTabItem8.Text = "รายการที่ประสบความสำเร็จ"
                SuperTabItem9.Text = "รายการเตือนภัย"
                SuperTabItem10.Text = "รายการ Null"
                SuperTabItem15.Text = "ข้อมูล"
                SuperTabItem12.Text = "ขั้นตอน"
                SuperTabItem13.Text = "ข้อยกเว้น"
                SuperTabItem14.Text = "ตัวแปร"
                Btn_Show_Information.Text = "เมนู"
                Node1.Text = "[วิเคราะห์]"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Turkish Then
#Region "<Turkish>"
                Dock_Property.Text = "özellik"
                Dock_Tree.Text = "ağaç"
                Dock_ResultSummary.Text = "Sonuçlar"
                Dock_Information.Text = "Bilgi"
                Dock_Map.Text = "Harita"
                Dock_Resultats.Text = "Sonuçlar"
                Dock_Web.Text = "ağ"
                L_Pass.Text = "Geçiş"
                L_Fail.Text = "başarısız"
                L_Erreur.Text = "hatalar"
                L_Nul.Text = "Sonuçsuz"
                L_Load.Text = "Yük"
                SuperTabItem1.Text = "analiz"
                SuperTabItem2.Text = "Hipotez"
                SuperTabItem3.Text = "değişkenler"
                SuperTabItem4.Text = "Sonuçlar"
                SuperTabItem6.Text = "Kanıt"
                SuperTabItem16.Text = "Vücut"
                SuperTabItem20.Text = "Giriş"
                SuperTabItem23.Text = "Çıktı"
                SuperTabItem26.Text = "eleman"
                SuperTabItem21.Text = "sicim"
                SuperTabItem22.Text = "özellik"
                SuperTabItem24.Text = "sicim"
                SuperTabItem25.Text = "özellik"
                SuperTabItem5.Text = "listeleri"
                SuperTabItem7.Text = "Başarısız Liste"
                SuperTabItem8.Text = "Başarı listesi"
                SuperTabItem9.Text = "Uyarı listesi"
                SuperTabItem10.Text = "Liste Boş"
                SuperTabItem15.Text = "Bilgi"
                SuperTabItem12.Text = "adımlar"
                SuperTabItem13.Text = "istisnalar"
                SuperTabItem14.Text = "değişkenler"
                Btn_Show_Information.Text = "Menü"
                Node1.Text = "[Analiz]"

#End Region
            End If
#End Region

            _Language = value
        End Set
    End Property

#Region "<Events>"
    Private Sub Btn_Show_Information_Click(sender As Object, e As EventArgs) Handles Btn_Show_Information.Click
        If Dock_Information.Visible = False Then
            If Bar_Info.Visible = False Then
                Bar_Info.Visible = True
            End If
            Dock_Information.Visible = True
        ElseIf Dock_Information.Visible = True Then
            Dock_Information.Visible = False
        End If
    End Sub
    Private Sub Btn_Show_Resultats_Click(sender As Object, e As EventArgs) Handles Btn_Show_Resultats.Click
        If Dock_Resultats.Visible = False Then
            If Bar_Info.Visible = False Then
                Bar_Info.Visible = True
            End If
            Dock_Resultats.Visible = True
        ElseIf Dock_Resultats.Visible = True Then
            Dock_Resultats.Visible = False
            If Dock_Information.Visible = False Then
                If Dock_Map.Visible = False Then
                    If Dock_Web.Visible = False Then
                        Bar_Info.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Btn_Show_Map_Click(sender As Object, e As EventArgs) Handles Btn_Show_Map.Click
        If Dock_Map.Visible = False Then
            If Bar_Info.Visible = False Then
                Bar_Info.Visible = True
            End If
            Dock_Map.Visible = True
        ElseIf Dock_Map.Visible = True Then
            Dock_Map.Visible = False
            If Dock_Resultats.Visible = False Then
                If Dock_Information.Visible = False Then
                    Bar_Info.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub Btn_Show_ResultSummary_Click(sender As Object, e As EventArgs) Handles Btn_Show_ResultSummary.Click
        If Dock_ResultSummary.Visible = False Then
            Dock_ResultSummary.Visible = True
        ElseIf Dock_ResultSummary.Visible = True Then
            Dock_ResultSummary.Visible = False
        End If
    End Sub
    Private Sub Btn_Show_Tree_Click(sender As Object, e As EventArgs) Handles Btn_Show_Tree.Click
        If Dock_Tree.Visible = False Then
            If Bar_Result.Visible = False Then
                Bar_Result.Visible = True
            End If
            Dock_Tree.Visible = True
        ElseIf Dock_Tree.Visible = True Then
            Dock_Tree.Visible = False
            If Bar_Result.Visible = False Then
                Bar_Result.Visible = False
            End If
        End If
    End Sub
    Private Sub Btn_ShowHide_Property_Click(sender As Object, e As EventArgs) Handles Btn_ShowHide_Property.Click
        If Dock_Property.Visible = False Then
            If Bar_Result.Visible = False Then
                Bar_Result.Visible = True
            End If
            Dock_Property.Visible = True
        ElseIf Dock_Property.Visible = True Then
            Dock_Property.Visible = False
            If Bar_Result.Visible = False Then
                Bar_Result.Visible = False
            End If
        End If
    End Sub
    Private Sub Btn_ShowHide_Web_Click(sender As Object, e As EventArgs) Handles Btn_ShowHide_Web.Click
        If Dock_Web.Visible = False Then
            If Bar_Info.Visible = False Then
                Bar_Info.Visible = True
            End If
            Dock_Web.Visible = True
        ElseIf Dock_Web.Visible = True Then
            Dock_Web.Visible = False
            If Dock_Information.Visible = False Then
                If Dock_Map.Visible = False Then
                    If Dock_Resultats.Visible = False Then
                        Bar_Info.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
#End Region
    Private _ListOfTests As List(Of TestItem)
    Public Property ListOfTests() As List(Of TestItem)
        Get
            Return _ListOfTests
        End Get
        Set(ByVal value As List(Of TestItem))
            If IsNothing(value) Then
            Else
                ' If CB_Tests.Items.Count - 1 > 0 Then
                'CB_Tests.Items.Clear()
                'End If
                '   For i = 0 To value.Count - 1
                '  CB_Tests.Items.Add(value(i))
                ' Next
            End If
            _ListOfTests = value
        End Set
    End Property

    Public Sub Add(ByVal Test As TestItem, Optional ByVal AddToAnalyse As Boolean = False)
        If IsNothing(ListOfTests) Then
            ListOfTests = New List(Of TestItem)
        End If

        If AddToAnalyse = True Then
            Analyse.Add(Test)
            Cmd_Refresh.Execute()
            If CB_Tests.Items.Count - 1 > 0 Then
                CB_Tests.Items.Clear()
            End If
            CB_Tests.Items.Add(Analyse)
            If IsNothing(Analyse.Results) Then
            Else

                For i = 0 To Analyse.Results.Count - 1
                    ListOfTests.Add(Analyse.Results(i))
                    CB_Tests.Items.Add(Analyse.Results(i))
                Next
            End If
        Else
            ListOfTests.Add(Test)
            CB_Tests.Items.Add(Test)
            Node1.Nodes.Add(Test.Node.DeepCopy)
            Node2.Nodes.Add(Test.NodeG.DeepCopy)
        End If

    End Sub
#Region "<0> [Property]"
#Region "<00.00> <Property> [TestItem]"
#Region "<00.00.00> <Property> <TestItem> [Analyse | TestItem]"
    Private _Analyse As TestItem
    Public Property Analyse() As TestItem
        Get
            Return _Analyse
        End Get
        Set(ByVal value As TestItem)
            If IsNothing(value) Then
            Else

            End If
            _Analyse = value
        End Set
    End Property


#End Region
#End Region

#End Region
    Private Sub Cmd_Refresh_Executed(sender As Object, e As EventArgs) Handles Cmd_Refresh.Executed
        If IsNothing(Analyse) Then
            Analyse = ApplicationDLL
        End If
        'Format Title
        '
        'TitleText = Analyse.Name
        Text = Analyse.Name
        '   L_TestName.ForeColor = Color.White
        '
        'Retrieve Results Percentage
        '
        Txt_Fail.Text = "(" & Analyse.Percentage_Fail & " %)"
        Txt_Pass.Text = "(" & Analyse.Percentage_Pass & " %)"
        Txt_Nul.Text = "(" & Analyse.Percentage_Nul & " %)"
        Txt_Warning.Text = "(" & Analyse.Percentage_Warning & " %)"
        '   >Printing results also in small report
        Txt_Fail2.Text = "(" & Analyse.Percentage_Fail & " %)"
        Txt_Nul2.Text = "(" & Analyse.Percentage_Nul & " %)"
        Txt_Pass2.Text = "(" & Analyse.Percentage_Pass & " %)"
        Txt_Erreur2.Text = "(" & Analyse.Percentage_Warning & " %)"
        '
        'Format Node1 for DevComponents.DotNetBar.AdvTree
        '
        Node1.Text = "[Analyse] " & Analyse.Name
        Node1.ImageIndex = 10
        Node1.Tag = Analyse
        Node1.Tooltip = Analyse.Hypothesis
        '
        'Format Node 2 for DevComponents.DotNetBar.Tree
        '
        Node2.Text = "[Analyse] " & Analyse.Name
        Node2.ImageIndex = 10
        Node2.Tag = Analyse
        ' Node2.Nodes.Add()
        '
        'Clip the Properties in the PropertyGrid
        '
        iProperty.SelectedObject = Analyse
        '
        'Print the Hypothesis
        '
        Hypothesis.Text = Analyse.Hypothesis
        '
        'Print Input Variables
        '
        '   >For Input
        Txt_InputString.Text = Analyse.InputString
        Input_Prop.SelectedObject = Analyse.Input
        '   >For Output
        Txt_OutputString.Text = Analyse.InputString
        Prop_Output.SelectedObject = Analyse.Output
        '   >For Object Analysed
        Prop_Object_Analysed.SelectedObject = Analyse.Input
        '
        'Preparing Status
        '   >Check if items are not empty of CB_Status
        If CB_Status.Items.Count - 1 >= 0 Then
            CB_Status.Items.Clear()
        End If
        '   >Populating CB_Status
        CB_Status.Items.Add(Status.Broken.ToString)
        CB_Status.Items.Add(Status.Finished.ToString)
        CB_Status.Items.Add(Status.IsNothing.ToString)
        CB_Status.Items.Add(Status.NotTested.ToString)
        CB_Status.Items.Add(Status.Offline.ToString)
        CB_Status.Items.Add(Status.Online.ToString)
        CB_Status.Items.Add(Status.Running.ToString)
        CB_Status.Items.Add(Status.StandBye.ToString)
        CB_Status.Items.Add(Status.Warning.ToString)
        '   >Storing the actual Analyse
        CB_Status.Text = Analyse.Status.ToString
        '
        'Preparing List_Results
        '   >Clear content if any
        If List_Results.Items.Count - 1 > 0 Then
            List_Results.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.Results is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.Results) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.Results
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Results.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Results.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Fail
        '   >Clear content if any
        If List_Fail.Items.Count - 1 > 0 Then
            List_Fail.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Fail <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Fails is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Fails) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Fails
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Fail.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Fail.Items.Add(it)
                Next
            End If
        End If
        '
        'Preparing List_Success
        '   >Clear content if any
        If List_Success.Items.Count - 1 > 0 Then
            List_Success.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Pass <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Pass is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Pass) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Pass
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Success.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Success.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Warning
        '   >Clear content if any
        If List_Warning.Items.Count - 1 > 0 Then
            List_Warning.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Warning <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Warning is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Warning) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Warning
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Warning.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Warning.Items.Add(it)
                Next
            End If

        End If
        '
        'Preparing List_Nul
        '   >Clear content if any
        If List_Nul.Items.Count - 1 > 0 Then
            List_Nul.Items.Clear()
        End If
        '   >Detecting if any test are recorded
        If Analyse.Count_Pass <= 0 Then
            'No sub test recorded
        Else
            'verifiying this statement by analysing if Analyse.List_Pass is nothing
            'to avoid exception during runtime.
            If IsNothing(Analyse.List_Nul) Then
                'Exception captured. Count is not properly set
                MsgBox("Exception captured. Count is not properly set")
            Else
                'sub test recorded
                For Each Element As TestItem In Analyse.List_Nul
                    'Creating a New ListViewItem
                    Dim it As New ListViewItem
                    With it
                        .Name = Element.Name
                        .ImageIndex = Element.Status
                        .Text = FormatDateTime(Element.Time)
                        .SubItems.Add(Element.ID) 'List_Nul.Items.Count)
                        .SubItems.Add(Element.Name)
                        .SubItems.Add(Element.Hypothesis)
                        .SubItems.Add(Element.Status.ToString)
                        .Tag = Element
                        .ToolTipText = Element.Hypothesis
                    End With
                    List_Nul.Items.Add(it)
                Next
            End If

        End If
        '
        'Printing the report track Analyse
        Why.Text = Analyse.Why
        '
        'Printing the body
        Body.Text = Analyse.Body
        '
        'Preparing List_Events
        '   >Clear content if any
        If List_Events.Items.Count - 1 > 0 Then
            List_Events.Items.Clear()
        End If
        'verifiying this statement by analysing if Analyse.List_Fails is nothing
        'to avoid exception during runtime.
        If IsNothing(Analyse.Events) Then
            'Exception captured. Count is not properly set
            MsgBox("Exception captured. Count is not properly set")
        Else
            'sub test recorded
            For Each Element As TestItem.Evenement In Analyse.Events
                'Creating a New ListViewItem
                Dim it As New ListViewItem
                With it
                    .Name = Element.Name
                    .ImageIndex = Element.Status
                    .Text = Element.ID '
                    .SubItems.Add(Element.Name)
                    .SubItems.Add(FormatDateTime(Element.Time))
                    .SubItems.Add(Element.Status.ToString)
                    .SubItems.Add(Element.Description)
                    .SubItems.Add(Element.Hypothesis)
                    .SubItems.Add(Element.Ref)
                    .Tag = Element.Tag
                    .ToolTipText = Element.Hypothesis
                End With
                List_Events.Items.Add(it)
            Next
        End If
        '
        'Preparing List_Events
        '   >Clear content if any
        If List_Exceptions.Items.Count - 1 > 0 Then
            List_Exceptions.Items.Clear()
        End If
        'verifiying this statement by analysing if Analyse.List_Fails is nothing
        'to avoid exception during runtime.
        If IsNothing(Analyse.Bugs) Then
            'Exception captured. Count is not properly set
            MsgBox("Exception captured. Count is not properly set")
        Else
            'sub test recorded
            For Each Element As TestItem.Bug In Analyse.Bugs
                'Creating a New ListViewItem
                Dim it As New ListViewItem
                With it
                    .Name = Element.Name
                    .ImageIndex = Status.Warning
                    .Text = Element.ID '
                    .SubItems.Add(FormatDateTime(Element.Time))
                    .SubItems.Add(Element.Name)
                    .SubItems.Add(Element.Source)
                    .SubItems.Add(Element.Message)
                    .SubItems.Add(Element.TargetSite)
                    .SubItems.Add(Element.StackTrace)
                    .SubItems.Add(Element.HelpLink)
                    .Tag = Element
                    .ToolTipText = Element.Message
                End With
                List_Exceptions.Items.Add(it)
            Next
        End If
        '
#Region "<Printing Variables>"
        Analyse.Report(True)
        Node1.Nodes.Add(Analyse.Node.DeepCopy)
        Node2.Nodes.Add(Analyse.NodeG.DeepCopy)
#End Region


    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Analyse = New TestItem("Analyse", "Sans référence")
        Language = ConvertLangue_ToInt(If(My.Settings.Langue = "", "Français", My.Settings.Langue))
    End Sub

    Private Sub iProperty_Click(sender As Object, e As EventArgs) Handles iProperty.Click

    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        ApplicationDLL.Report(True)
        Analyse = ApplicationDLL
        Cmd_Refresh.Execute()
    End Sub

    Private Sub ButtonItem10_Click(sender As Object, e As EventArgs) Handles ButtonItem10.Click
        GetAllClasses()
        All_Classes.Report(True)
        Analyse = All_Classes
        Cmd_Refresh.Execute()

    End Sub

    Private Sub AdvTree1_DoubleClick(sender As Object, e As EventArgs) Handles AdvTree1.DoubleClick
        Try
            If IsNothing(AdvTree1.SelectedNode) Then
            Else
                If IsNothing(AdvTree1.SelectedNode.Tag) Then
                Else
                    Analyse = AdvTree1.SelectedNode.Tag
                    Cmd_Refresh.Execute()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        Analyse.Email_Saadry()
    End Sub
    Public Property SelectedTest As TestItem
    Private Sub CB_Tests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Tests.SelectedIndexChanged
        If IsNothing(CB_Tests.SelectedItem) Then
        Else
            If TypeOf CB_Tests.SelectedItem Is TestItem Then
                SelectedTest = CB_Tests.SelectedItem
                Dim addnew As Boolean = True
                For i = 0 To Node1.Nodes.Count - 1
                    If Node1.Nodes(i).Text = SelectedTest.Text Then
                        addnew = False
                    End If
                Next
                If addnew = True Then

#Region "<BS>"
                    'Format Title
                    '
                    'TitleText = Analyse.Name
                    Text = SelectedTest.Name
                    '   L_TestName.ForeColor = Color.White
                    '
                    'Retrieve Results Percentage
                    '
                    Txt_Fail.Text = "(" & SelectedTest.Percentage_Fail & " %)"
                    Txt_Pass.Text = "(" & SelectedTest.Percentage_Pass & " %)"
                    Txt_Nul.Text = "(" & SelectedTest.Percentage_Nul & " %)"
                    Txt_Warning.Text = "(" & SelectedTest.Percentage_Warning & " %)"
                    '   >Printing results also in small report
                    Txt_Fail2.Text = "(" & SelectedTest.Percentage_Fail & " %)"
                    Txt_Nul2.Text = "(" & SelectedTest.Percentage_Nul & " %)"
                    Txt_Pass2.Text = "(" & SelectedTest.Percentage_Pass & " %)"
                    Txt_Erreur2.Text = "(" & SelectedTest.Percentage_Warning & " %)"
                    '
                    'Format Node1 for DevComponents.DotNetBar.AdvTree
                    '
                    With SelectedTest.Node
                        .ImageIndex = SelectedTest.Status
                        .Tag = SelectedTest
                    End With
                    With SelectedTest.NodeG
                        .ImageIndex = SelectedTest.Status
                        .Tag = SelectedTest
                    End With
                    Node1.Nodes.Add(SelectedTest.Node)
                    Node2.Nodes.Add(SelectedTest.NodeG)
                    ' Node1.Text = "[Analyse] " & Analyse.Name
                    'Node1.ImageIndex = 10
                    'Node1.Tag = Analyse
                    'Node1.Tooltip = Analyse.Hypothesis
                    '
                    'Format Node 2 for DevComponents.DotNetBar.Tree
                    '
                    ' Node2.Text = "[Analyse] " & Analyse.Name
                    'Node2.ImageIndex = 10
                    'Node2.Tag = Analyse
                    ' Node2.Nodes.Add()
                    '
                    'Clip the Properties in the PropertyGrid
                    '
                    iProperty.SelectedObject = SelectedTest
                    '
                    'Print the Hypothesis
                    '
                    Hypothesis.Text = SelectedTest.Hypothesis
                    '
                    'Print Input Variables
                    '
                    '   >For Input
                    Txt_InputString.Text = SelectedTest.InputString
                    Input_Prop.SelectedObject = SelectedTest.Input
                    '   >For Output
                    Txt_OutputString.Text = SelectedTest.InputString
                    Prop_Output.SelectedObject = SelectedTest.Output
                    '   >For Object Analysed
                    Prop_Object_Analysed.SelectedObject = SelectedTest.Input
                    '
                    'Preparing Status
                    '   >Check if items are not empty of CB_Status
                    If CB_Status.Items.Count - 1 >= 0 Then
                        CB_Status.Items.Clear()
                    End If
                    '   >Populating CB_Status
                    CB_Status.Items.Add(Status.Broken.ToString)
                    CB_Status.Items.Add(Status.Finished.ToString)
                    CB_Status.Items.Add(Status.IsNothing.ToString)
                    CB_Status.Items.Add(Status.NotTested.ToString)
                    CB_Status.Items.Add(Status.Offline.ToString)
                    CB_Status.Items.Add(Status.Online.ToString)
                    CB_Status.Items.Add(Status.Running.ToString)
                    CB_Status.Items.Add(Status.StandBye.ToString)
                    CB_Status.Items.Add(Status.Warning.ToString)
                    '   >Storing the actual Analyse
                    CB_Status.Text = SelectedTest.Status.ToString
                    '
                    'Preparing List_Results
                    '   >Clear content if any
                    If List_Results.Items.Count - 1 > 0 Then
                        List_Results.Items.Clear()
                    End If
                    '   >Detecting if any test are recorded
                    If SelectedTest.Count <= 0 Then
                        'No sub test recorded
                    Else
                        'verifiying this statement by analysing if Analyse.Results is nothing
                        'to avoid exception during runtime.
                        If IsNothing(SelectedTest.Results) Then
                            'Exception captured. Count is not properly set
                            MsgBox("Exception captured. Count is not properly set")
                        Else
                            'sub test recorded
                            For Each Element As TestItem In SelectedTest.Results
                                'Creating a New ListViewItem
                                Dim it As New ListViewItem
                                With it
                                    .Name = Element.Name
                                    .ImageIndex = Element.Status
                                    .Text = FormatDateTime(Element.Time)
                                    .SubItems.Add(Element.ID) 'List_Results.Items.Count)
                                    .SubItems.Add(Element.Name)
                                    .SubItems.Add(Element.Hypothesis)
                                    .SubItems.Add(Element.Status.ToString)
                                    .Tag = Element
                                    .ToolTipText = Element.Hypothesis
                                End With
                                List_Results.Items.Add(it)
                            Next
                        End If

                    End If
                    '
                    'Preparing List_Fail
                    '   >Clear content if any
                    If List_Fail.Items.Count - 1 > 0 Then
                        List_Fail.Items.Clear()
                    End If
                    '   >Detecting if any test are recorded
                    If SelectedTest.Count_Fail <= 0 Then
                        'No sub test recorded
                    Else
                        'verifiying this statement by analysing if Analyse.List_Fails is nothing
                        'to avoid exception during runtime.
                        If IsNothing(SelectedTest.List_Fails) Then
                            'Exception captured. Count is not properly set
                            MsgBox("Exception captured. Count is not properly set")
                        Else
                            'sub test recorded
                            For Each Element As TestItem In SelectedTest.List_Fails
                                'Creating a New ListViewItem
                                Dim it As New ListViewItem
                                With it
                                    .Name = Element.Name
                                    .ImageIndex = Element.Status
                                    .Text = FormatDateTime(Element.Time)
                                    .SubItems.Add(Element.ID) 'List_Fail.Items.Count)
                                    .SubItems.Add(Element.Name)
                                    .SubItems.Add(Element.Hypothesis)
                                    .SubItems.Add(Element.Status.ToString)
                                    .Tag = Element
                                    .ToolTipText = Element.Hypothesis
                                End With
                                List_Fail.Items.Add(it)
                            Next
                        End If
                    End If
                    '
                    'Preparing List_Success
                    '   >Clear content if any
                    If List_Success.Items.Count - 1 > 0 Then
                        List_Success.Items.Clear()
                    End If
                    '   >Detecting if any test are recorded
                    If SelectedTest.Count_Pass <= 0 Then
                        'No sub test recorded
                    Else
                        'verifiying this statement by analysing if Analyse.List_Pass is nothing
                        'to avoid exception during runtime.
                        If IsNothing(SelectedTest.List_Pass) Then
                            'Exception captured. Count is not properly set
                            MsgBox("Exception captured. Count is not properly set")
                        Else
                            'sub test recorded
                            For Each Element As TestItem In Analyse.List_Pass
                                'Creating a New ListViewItem
                                Dim it As New ListViewItem
                                With it
                                    .Name = Element.Name
                                    .ImageIndex = Element.Status
                                    .Text = FormatDateTime(Element.Time)
                                    .SubItems.Add(Element.ID) 'List_Success.Items.Count)
                                    .SubItems.Add(Element.Name)
                                    .SubItems.Add(Element.Hypothesis)
                                    .SubItems.Add(Element.Status.ToString)
                                    .Tag = Element
                                    .ToolTipText = Element.Hypothesis
                                End With
                                List_Success.Items.Add(it)
                            Next
                        End If

                    End If
                    '
                    'Preparing List_Warning
                    '   >Clear content if any
                    If List_Warning.Items.Count - 1 > 0 Then
                        List_Warning.Items.Clear()
                    End If
                    '   >Detecting if any test are recorded
                    If SelectedTest.Count_Warning <= 0 Then
                        'No sub test recorded
                    Else
                        'verifiying this statement by analysing if Analyse.List_Warning is nothing
                        'to avoid exception during runtime.
                        If IsNothing(SelectedTest.List_Warning) Then
                            'Exception captured. Count is not properly set
                            MsgBox("Exception captured. Count is not properly set")
                        Else
                            'sub test recorded
                            For Each Element As TestItem In Analyse.List_Warning
                                'Creating a New ListViewItem
                                Dim it As New ListViewItem
                                With it
                                    .Name = Element.Name
                                    .ImageIndex = Element.Status
                                    .Text = FormatDateTime(Element.Time)
                                    .SubItems.Add(Element.ID) 'List_Warning.Items.Count)
                                    .SubItems.Add(Element.Name)
                                    .SubItems.Add(Element.Hypothesis)
                                    .SubItems.Add(Element.Status.ToString)
                                    .Tag = Element
                                    .ToolTipText = Element.Hypothesis
                                End With
                                List_Warning.Items.Add(it)
                            Next
                        End If

                    End If
                    '
                    'Preparing List_Nul
                    '   >Clear content if any
                    If List_Nul.Items.Count - 1 > 0 Then
                        List_Nul.Items.Clear()
                    End If
                    '   >Detecting if any test are recorded
                    If SelectedTest.Count_Pass <= 0 Then
                        'No sub test recorded
                    Else
                        'verifiying this statement by analysing if Analyse.List_Pass is nothing
                        'to avoid exception during runtime.
                        If IsNothing(SelectedTest.List_Nul) Then
                            'Exception captured. Count is not properly set
                            MsgBox("Exception captured. Count is not properly set")
                        Else
                            'sub test recorded
                            For Each Element As TestItem In Analyse.List_Nul
                                'Creating a New ListViewItem
                                Dim it As New ListViewItem
                                With it
                                    .Name = Element.Name
                                    .ImageIndex = Element.Status
                                    .Text = FormatDateTime(Element.Time)
                                    .SubItems.Add(Element.ID) 'List_Nul.Items.Count)
                                    .SubItems.Add(Element.Name)
                                    .SubItems.Add(Element.Hypothesis)
                                    .SubItems.Add(Element.Status.ToString)
                                    .Tag = Element
                                    .ToolTipText = Element.Hypothesis
                                End With
                                List_Nul.Items.Add(it)
                            Next
                        End If

                    End If
                    '
                    'Printing the report track Analyse
                    Why.Text = SelectedTest.Why
                    '
                    'Printing the body
                    Body.Text = SelectedTest.Body
                    '
                    'Preparing List_Events
                    '   >Clear content if any
                    If List_Events.Items.Count - 1 > 0 Then
                        List_Events.Items.Clear()
                    End If
                    'verifiying this statement by analysing if Analyse.List_Fails is nothing
                    'to avoid exception during runtime.
                    If IsNothing(SelectedTest.Events) Then
                        'Exception captured. Count is not properly set
                        MsgBox("Exception captured. Count is not properly set")
                    Else
                        'sub test recorded
                        For Each Element As TestItem.Evenement In SelectedTest.Events
                            'Creating a New ListViewItem
                            Dim it As New ListViewItem
                            With it
                                .Name = Element.Name
                                .ImageIndex = Element.Status
                                .Text = Element.ID '
                                .SubItems.Add(Element.Name)
                                .SubItems.Add(FormatDateTime(Element.Time))
                                .SubItems.Add(Element.Status.ToString)
                                .SubItems.Add(Element.Description)
                                .SubItems.Add(Element.Hypothesis)
                                .SubItems.Add(Element.Ref)
                                .Tag = Element.Tag
                                .ToolTipText = Element.Hypothesis
                            End With
                            List_Events.Items.Add(it)
                        Next
                    End If
                    '
                    'Preparing List_Events
                    '   >Clear content if any
                    If List_Exceptions.Items.Count - 1 > 0 Then
                        List_Exceptions.Items.Clear()
                    End If
                    'verifiying this statement by analysing if Analyse.List_Fails is nothing
                    'to avoid exception during runtime.
                    If IsNothing(SelectedTest.Bugs) Then
                        'Exception captured. Count is not properly set
                        MsgBox("Exception captured. Count is not properly set")
                    Else
                        'sub test recorded
                        For Each Element As TestItem.Bug In SelectedTest.Bugs
                            'Creating a New ListViewItem
                            Dim it As New ListViewItem
                            With it
                                .Name = Element.Name
                                .ImageIndex = Status.Warning
                                .Text = Element.ID '
                                .SubItems.Add(FormatDateTime(Element.Time))
                                .SubItems.Add(Element.Name)
                                .SubItems.Add(Element.Source)
                                .SubItems.Add(Element.Message)
                                .SubItems.Add(Element.TargetSite)
                                .SubItems.Add(Element.StackTrace)
                                .SubItems.Add(Element.HelpLink)
                                .Tag = Element
                                .ToolTipText = Element.Message
                            End With
                            List_Exceptions.Items.Add(it)
                        Next
                    End If
                    '
#Region "<Printing Variables>"
                    SelectedTest.Report(True)
                    Node1.Nodes.Add(Analyse.Node.DeepCopy)
                    Node2.Nodes.Add(Analyse.NodeG.DeepCopy)
#End Region


#End Region
                End If
            End If
        End If
    End Sub

    Private Sub List_Exceptions_Click(sender As Object, e As EventArgs) Handles List_Exceptions.Click
        If IsNothing(List_Exceptions.SelectedItems(0).Tag) Then
        Else
            Dim B As TestItem.Bug
            B = List_Exceptions.SelectedItems(0).Tag
            Dim PrintBug As New PrintException(B.SelectedException)
            PrintBug.Show()
        End If

    End Sub

    Private Sub List_Results_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Results.SelectedIndexChanged

    End Sub

    Private Sub List_Fail_DoubleClick(sender As Object, e As EventArgs) Handles List_Fail.DoubleClick
        If IsNothing(List_Fail.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Fail.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Fail.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Results_DoubleClick(sender As Object, e As EventArgs) Handles List_Results.DoubleClick
        If IsNothing(List_Results.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Results.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Results.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Success_DoubleClick(sender As Object, e As EventArgs) Handles List_Success.DoubleClick
        If IsNothing(List_Success.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Success.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Success.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Warning_DoubleClick(sender As Object, e As EventArgs) Handles List_Warning.DoubleClick
        If IsNothing(List_Warning.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Warning.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Warning.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub

    Private Sub List_Nul_DoubleClick(sender As Object, e As EventArgs) Handles List_Nul.DoubleClick
        If IsNothing(List_Nul.SelectedItems(0).Tag) Then
        Else
            If TypeOf List_Nul.SelectedItems(0).Tag Is TestItem Then
                Dim PR As New Print_ResultItem(List_Nul.SelectedItems(0).Tag)
                PR.Show()
            End If
        End If
    End Sub
End Class
