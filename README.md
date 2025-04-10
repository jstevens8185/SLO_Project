# 🎓 SLO Manager Application

A Windows Forms application for entering, viewing, and analyzing Student Learning Outcome (SLO) scores. Built with C#, Entity Framework 6, and SQL Server LocalDB. Designed to support score tracking by year, SLO, and measurement, and visualize the results in chart form.

---

## 🗂 Project Structure

This is a multi-project Visual Studio solution:

- SloManager — The main WinForms UI project  
- SlosClassLibrary — Class library containing Entity Framework models and the SloDatabaseEntities context  

---

## 🚀 Features

- Add multiple score entries with a year, SLO, measurement, and grade  
- Batch save scores to the database  
- View and delete saved score data in a DataGridView  
- View charts of average scores filtered by selected year range  

---

## 🔧 Prerequisites

- Visual Studio 2022 or newer  
- .NET Framework 4.7.2 or newer  
- SQL Server Express LocalDB (usually installed with Visual Studio)  
- Git (optional for version control)  

---

## 💻 How to Run the Project on a New Machine

1. Clone the Repository  
   git clone https://github.com/jstevens8185/SLO_Project.git  
   cd SLO_Project

2. Open the Solution in Visual Studio  
   Open SLO_Project.sln  
   You should see two projects: SloManager and SlosClassLibrary  

3. Add Missing Projects (if needed)  
   If SlosClassLibrary does not appear:  
   - Right-click the solution in Solution Explorer  
   - Click Add > Existing Project  
   - Select SlosClassLibrary\SlosClassLibrary.csproj  

4. Add Project Reference  
   - Right-click the SloManager project  
   - Click Add > Project Reference  
   - Check SlosClassLibrary  
   - Click OK  

5. Restore NuGet Packages  
   - Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution  
   - Click Restore to install Entity Framework and other dependencies  

6. Setup the Database  
   If you're using the .mdf file (Database First setup):  
   - Copy SloDatabase.mdf and SloDatabase_log.ldf from your dev machine  
   - Paste them into SloManager\bin\Debug\  
   - In Visual Studio, right-click SloDatabase.mdf  
     - Set Build Action: Content  
     - Set Copy to Output Directory: Copy if newer  

7. Confirm App.config Connection String  
   Make sure your App.config includes the following connection string:  
   Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SloDatabase.mdf;Integrated Security=True;Connect Timeout=30  
   Note: |DataDirectory| maps to the bin\Debug\ folder at runtime  

8. Clean and Build the Solution  
   - Build > Clean Solution  
   - Build > Rebuild Solution  

9. Run the App  
   - Press F5 or click the Start button  

---

## 📊 Using the Application

- Use the Enter Data form to add score entries  
- Select SLO, measurement, year, and grade, then add to the list  
- Click Save All to store entries in the database  
- Use the View Scores form to browse and delete records  
- Use the View Charts form to select a year range and see average scores visualized  

---

## 🛠 Troubleshooting

**Problem: 'SlosClassLibrary' not found**  
- Make sure both projects are in the solution  
- Add a project reference from SloManager to SlosClassLibrary  
- Clean and rebuild the solution  

**Problem: System.Data.Entity not found**  
- Install the EntityFramework NuGet package for both projects  
- Rebuild the solution  

**Problem: The underlying provider failed on Open**  
- Your .mdf file is missing or locked  
- Ensure the .mdf is in bin\Debug  
- Confirm the App.config connection string is correct  
- Close any tool (like SSMS) that might be locking the file  

**Problem: .vsidx permission denied or "adding files failed"**  
- You're trying to git add Visual Studio temp files  
- Make sure your .gitignore includes:  
  .vs/  
  bin/  
  obj/  
  *.user  
  *.suo  
  *.mdf  
  *.ldf  

---

## 🧰 Technologies Used

- C#  
- WinForms  
- Entity Framework 6  
- SQL Server LocalDB  
- Charting via System.Windows.Forms.DataVisualization  

---

## 💡 Optional Enhancements

- Add Code First + Migrations to auto-generate the DB  
- Export chart/data to Excel or PDF  
- Add user authentication or roles  
- Add chart type dropdown or filters by measurement  


