# DiyetUygulamasi-ProDiet
Bu Windows form uygulaması, CodeFirst yaklaşımı ile katmanlı mimari kullanarak veri tabanı oluşturuyor. Kullanıcılar kalori hesaplama, öğün takibi, günlük CRUD işlemleri ve diğer kullanıcılarla haftalık ve aylık bazda grafik destekli kalori tüketim kıyaslaması yapabilirler.

#ProDiet – README
- Bu Windows form uygulaması, katmanlı mimari tasarımı kullanılarak CodeFirst yaklaşımı ile bir veri tabanı oluşturuyor. Uygulama, kullanıcılardan alınan bilgilere göre kişiye özel kalori hesaplaması yaparak, kullanıcının öğün bazında besin tüketimini takip edebilmesini sağlıyor. Ayrıca, kullanıcıların günlük kalori tüketimini yönetmek için CRUD işlemleri gerçekleştirebiliyor.

- Uygulama, kullanıcıların kalori tüketimlerini diğer kullanıcılarla karşılaştırabileceği bir grafik sunuyor. Kullanıcılar, haftalık ve aylık bazda kıyaslamalar yaparak kalori tüketimlerini izleyebiliyorlar.

- Uygulamanın çalıştırılabilmesi için ‘Data Access Layer’ katmanında bulunan ‘Helpers’ sınıfına gidip SQL Server’ının adını kendi bilgisayar adınız ile değiştirmeniz gereklidir. Aşağıda bu işlemi nasıl yapacağınız daha detaylı bir biçimde anlatılmaktadır.

- Programın çalıştırılabilmesi için ‘Eventlerin’ tekrardan formlara yüklenmesi gerekebilir. Aşağıda belirtilen eventlerin atamasının yapılması gerekmektedir.

- Events must be reloaded into the forms in order to run the program. Events disappear when different accounts access and modify the program via Github. The following events must be assigned to the code.


#SQL Server Name
private static string _connectionString = @"Server=KAGANUNAL;Database=ProDietAppDB;Trusted_Connection=True;Trust Server Certificate=True";

private static string _connectionString = @"Server=YourPCName;Database=ProDietAppDB;Trusted_Connection=True;Trust Server Certificate=True";


#Events

- Form1 Events

lnkCreateAccount_LinkClicked
btnLogin_Click
Form1_Load
btnShowPassword_Click
Create Account Events
CreateAccount_Load
btnInfo_MouseEnter
btnInfo_MouseLeave
CreateAccount_Load
tmrWelcome_Tick
tmrOpenForm_Tick
btnContinue_Click
btnContinue_Click
btnSignUp_Click
txtPasswordCheck_TextChanged
txtName_Leave
txtLastName_Leave
txtName_TextChanged
txtLastName_TextChanged
txtEmail_TextChanged
txtPassword_TextChanged


- AddMeals Events

AddMeals_Load
btnClose_Click
btnAddMeal_Click
txtSearchFood_TextChanged
cbOrderByFilter_SelectedIndexChanged
dtpMealDate_ValueChanged
btnUpdate_Click
lstDailyMeal_SelectedIndexChanged
btnAdd_Click
btnAddPict_Click
dgvFoods_SelectionChanged
btnRemove_Click
dgvFoods_MouseClick
ucEditFoods Events
btnAdd_Click
btnAddPict_Click


- ucProPlan Events

ucProPlan_Load
lnkProTakip_LinkClicked
btnCreatePlan_Click
tmrWriteMessage_Tick


- ucProTakip Events
btnAddBreakFast_Click
btnAddLunch_Click
btnAddDinner_Click
btnAddExtra_Click
ShowDialogAddMeals
dtpMealDate_ValueChanged


- ucUserInfo Events
ıconButton2_Click
ıconButton1_Click


- ucExtraReport Events
btnMostConsumed_Click
btnLeastConsumed_Click


- ucMonthlyReport Events
btnCompareByCalorie_Click


- ucWeeklyReport Events
btnCompareByCalorie_Click
