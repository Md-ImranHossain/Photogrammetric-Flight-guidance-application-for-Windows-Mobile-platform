# Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform
This application has been created to direct the gyrocopter pilot along the proposed photogrammetric flight lines with visual graphics. This application has mainly three features. 
1.	Planning of photogrammetric flight lines
2.	visualize the position tracks by getting the real time position (latitude, longitude and altitude) data and rotations (omega, phi and kappa) data from the Xsens MTi-G device through serial port 
3.	Finally calculate the horizontal and vertical shift from the planned flight line and show the shifts as well as the rotations in a graphical user interface.

# 1. Background

In the department of Geomatics, Computer Science and Mathematics, Stuttgart University of Applied Sciences, the experimental investigation of aerial imaging using Gyrocopter was done in research lead by Prof. Dr. Michael Hahn in 2010. The main idea of the research was to investigate low cost instruments (camera and GPS receiver) mounted on a low cost platform. Even though the aerial photograph was carried out with Gyrocopter, an automated flight navigation tool is not still available (Miraliakbari, et al., 2009, p.109). Gyrocopter based aerial imaging gives an advantage for developing countries because of its low cost acquisition and maintenance. Therefore, this work is intended to develop a windows mobile based tool/ application to guide the Gyrocopter in aerial imaging process. The main purpose of the application is to get the real time position (latitude, longitude and altitude) data and rotation (omega, phi and kappa) data from the Xsens MTi-G device through serial port, calculate the  horizontal and vertical shift from the planned flight line and finally show the shifts as well as the rotations in a graphical user interface. 

# 2. Hardware and software used

Xsens MTi-G GPS-IMU device was used to get the real time position and rotation data. The application or tool has been developed in visual basic.NET programming language. A COM-object API namely xsensCMT.dll provided by the Xsens vendor has been used to get connected and receiving real time data from the MTi-G device. The application would work properly with MTi-G device and therefore, may not work with other GPS-IMU system. However, it is possible to connect other GPS-IMU system as well with a little change in the code.

# 3. Description of the application’s GUI

The application has mainly three graphical user interface. Each interface has its own uses and functionality. The functionality and uses of each interface are illustrated below.

## 3.1 Flight data input Interface

The application starts with an interface for necessary data input. The user has to insert some necessary flight data like map scale, focal length, start and end points of the flight line etc. All the options for data input interface are described below: 

### Map scale:  
user can select the map scale by clicking the drop down arrow. If suitable scale is missing in the drop down list, user can select custom from the drop down list. As soon as the custom option is selected the gray text box next to it would become enabled and change its color to white. The user can then insert their desire map scale in that text box.

### Focal length: 
focal length of the camera could be inserted with the same functionality as map scale input functionality.  However, please note that the input unit in this case is centimeter.

### Flight height above ground: 
as soon as the user inserts two parameters: map scale and focal length, flight height above ground would be automatically calculated in meter based on the following simple formula. 

Average Ground Height = (Map Sclae * Focal Length) / 100

### Average ground height: 
Average ground height is the average height of ground from the mean sea level. The user has to insert this parameter for any specific area of operation. This parameter must be in meter.

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture.PNG)
### Planned average flight height: 
This parameter in meter is just the summation of flight height above ground and average ground height. This parameter would be automatically calculated after inserting the average ground height. However, this parameter is an important one as because the positional height difference would be calculated later on based on this parameter.

### Max horz distance and Max vert distance: 
The position of the Gyrocopter would be shown in a graphical interface (fig. 2) later on. The horizontal line of the cross hair of figure 2 represents the horizontal distance of Gyrocopter’s position from the flight line with a scale. Vertical line on the other hand represents height difference from the planned flight line. The green dot is the real time position of the Gyrocopter. Now max horz distance and max vert distance has been provided in the data input interface so that the user can confined the maximum horizontal and vertical distance in which the location of the gyrocopter is visible. For example in figure 1, both of those parameter is set to 80m and the graph in figure 2 is scaled accordingly. therefore, if the horizontal and vertical distance of the Gyrocopter from the flight line is more than 80m then the green dots (position) would not be appear in the graph anymore.

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture1.PNG)
### Max horz tolerance and Max vert tolerance: 
The intersection point of the cross hair (fig. 2) is the desired location of the Gyrocopter at any time as because at that point horizontal and vertical positional displacement is 0. But due to many reason and errors it is not possible to perfectly position the Gyrocopter at the intersection. Therefore, a tolerance must be given in both distance direction in which the imaging process would be correct. However, the tolerance parameter is dependent on forward overlap, side overlap, map scale etc. According to the tolerance parameter given in data input interface, some green line (fig.2) would be appeared in the graph of guidance interface. The pilot must position the gyrocopter between those green lines for error free imaging. Figure 2 shows that the user defined horizontal tolerance is 40m and vertical tolerance is 20m.

### Inserting flight line parameters: 
There are mainly two options offered here: inserting the flight line data and editing flight line data. We will discuss firstly the insert option. The edit option would be discussed later. As you can see in the figure 1 that unlike ‘start inserting’ button, all other input box are disabled. Therefore the user can make enabled of the input boxes by clicking the button ‘start inserting’. The user must insert all the flight line in terms of start and end coordinate of lines. To insert the flight line parameter, the start inserting button must press first. With pressing the button a text file namely “FlightLineInfo” would be created in the C: drive for storing all the flight line parameter. Thereafter, for each flight line, the user must input a line no, latitude and longitude of start point and end points. The latitude and longitude must be in decimal degree format. The options for inserting those data are offered under the heading “Start and End points of flight lines (Degree). To decide whether the gyrocopter position is on the left hand side or right hand side of the flight line, it is very important to insert the start and end point of line very carefully. Start and end pint must be given according to flight direction Figure 3 illustrates the correct way of inserting start and end point of each flight line. If flight direction for line no 1 is A to B and for line no 2 is D to C then while inserting the start and end point of line 2, the flight direction must be considered. In this case, start and end point for line 2 would be D and C respectively. Start point as C and end point as D would be a wrong entry.

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture2.PNG)

Pressing the “Enter” button will add all the line parameter in to the text file as a text line (fig. 4) and make the text boxes ready for the next entry of flight line. However, a message box will appear to confirm the entry. In addition, the items of line no combo box under editing line option would be updated with the line no of start inserting option. Once the user enters all flight lines, the user can preview all the inputs or go directly to the guidance interface of the application through the main menu options (fig. 1). However, it is recommended that the user go to the preview first and check all the inputs and then go to the guidance interface. 

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture3.PNG)

## 3.2 Flight data preview interface

This interface is designed to view all flight input data at a glance for checking. As mentioned earlier the user can escape this phase and can go directly to the guidance interface. But it is always better to check the input data before fly to avoid any inconvenience later on.  Once the ‘Preview inputs’ button in the flight data input interface is clicked a new windows form would be open with all the input data (fig. 5). While checking, if any wrong input has been found, the user can go back to the input interface by simply clicking the main menu option “edit data”. Otherwise, if all the data are correct then the user chose the final guidance interface by clicking the main menu option “Show guidance”. 

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture4.PNG)

In case of wrong entry, pressing Edit data option will enable the input interface again. Here, the user simply can change any initial setting parameter or flight line parameter (fig. 6). To change any flight line parameter, the user must press the “Edit line” button. Once the “Edit line” button is pressed the options for editing lines would be enabled. In the drop down arrow beside the Line no., the no. of line in which editing or correction would be carried out should be select first. With the selection of line no, the associate entered latitude and longitude of start and end point would be loaded in the respective textbox beneath. Thereafter, the user can change or correct any values in the text boxes and press the “Update” button to update the data for that particular line. At this point, after changing all the input errors, the user can again go to the data preview interface for further checking or directly to the guidance interface.

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture5.PNG)

## 3.3 Guidance interface

The guidance interface is the main interface that helps the pilot to keep gyrocopters position in to the flight lines by showing graphical and textual direction. This graphical interface could be divided in to three main sections or parts. The sections are described below in terms of functionality and principles behind.

### Main menu items: 
There are five menu items in the guidance GUI with specific functionalities. The user have to first press the “Display Scale” menu to show the scales in the graph of “Horizontal and vertical displacement” section. The scale would be drawn according to the “Max horz distance” and “Max vert distance” defined in the flight data input interface (fig 7 A). Once the scale drawing is done, the application is now ready to start making connection to the MTi-G device. The user has to press the “start” menu in the main menu items in this regards. Pressing the start menu would result drawing green lines representing the max horz tolerance and max vertical tolerance defined in the flight data input interface(fig 7 A). Thereafter, the gyrocopter’s real time position (in terms of horizontal and vertical distance from the planned flight line) would be shown in the graph by green dots. 

![](https://github.com/Md-ImranHossain/Photogrammetric-Flight-guidance-application-for-Windows-Mobile-platform/blob/master/Pics/Capture6.PNG)

In addition the textual direction under the “horizontal and vertical displacement” section would be activated (fig 7 B) and real time angular displacement (Omega, Phi and Kappa) would be measured and shown in the “Angular displacement” section (fig 7 C).  Pressing the “Stop” button would stop the connection with the MTi-G device and therefore would not calculate the position and angles any more. 

The “Go to” menu consists of two sub menus. “Go to” menu has been provided to switch between graphical user interfaces. The user can go to the flight data input interface and preview interface by clicking the respective submenu option under the “Go to” main menu option. The very common exit menu has been provided to exit form application.

### Horizontal and vertical displacement section: 
Main purpose of this section of the interface is to visualize the three dimensional position of the gyrocopter with reference to the planned flight line. There are two parts of this section: the graphical part (fig. 7A) and the textual direction part (fig. 7B). 

The graphical part consists of a circle with cross hair and scale in both vertical and horizontal direction. The horizontal line of the cross hair represents the horizontal distance between the gyrocopter and flight line and the vertical line represents the vertical distance instead. The cross hair lines are scaled according to the max horz and vert distance defined in the data input interface. Two vertical green lines in the horizontal cross hair represent the maximum horizontal tolerance defined in the data input interface. Two horizontal green lines in the vertical cross hair represent the maximum vertical tolerance defined in the data input interface. The pilot should keep the gyrocopter in between those green lines for error free imaging. A green dot in the horizontal cross hair represents the position of gyrocopter in terms of horizontal distance from the planned flight line. A green dot in the vertical cross hair represents the position of gyrocopter in terms of vertical (height) distance from the planned flight line. Positive distance in the horizontal lines means the position of gyrocopter is in the left hand side of the flight line and negative distance means vice versa. On the other hand positive distance in vertical cross hair means the position of gyrocopter above the planned flight height and negative means below the planned flight height. Therefore, the intersection point of the cross hair is the desired position of the gyrocopter at any given time in reference to a particular flight line.

The pilot has to visually measure the distance of the green (gyrocopter position) dot from the flight line (cross hair) through respective scales. Sometimes it might be difficult for the pilot to interpret that distance visually. Therefore, a textual direction part (fig. 7B) has been developed to provide an instant guidance to the pilot. The textual direction part will show how many meters the pilot should move the gyrocopter left/right and up/down to get in the actual planned flight line. Sometimes, the horizontal and vertical distance of the gyrocopter may not be according to the desired flight line. For example, the pilot may want to go through flight line no. 3 to take images. But, if by mistake the gyrocopter is close to the line no 4 then the graph and textual direction will show the gyrocopter position in reference to the line no 4 mean how far it is from the line no.4. To overcome this problem, in the textual direction section, a variable would show the flight line no. to which the horizontal and vertical distance is calculated at that particular time. 

### Angular displacement section: 
The angular displacement section of in the guidance interface has been developed to visualize the three important angles (roll, pitch and yaw) of the gyrocopter (fig. 7B). For better imaging the platform (gyrocopter in this case) should be horizontal in reference to the ground. The angular displacement section would show whether the gyrocopter is horizontal or not by showing the angles roll and pitch in a +90° to -90° wheel. In addition the pilot can also see the yaw angle in a +180° to -180° wheel.

# 4.Conclusion

This application is a little initiative for guiding the pilot in the time of gyrocopter based aerial imaging. The flight guidance application has been developed solely for the Xsens MTi-G device. Therefore, this application with other GPS-IMU device may not work properly. But there are always opportunities to change a little portion of .NET code of the application to make other device connected and worked. In fact, the initial idea was to develop the application for windows mobile as the space in the cockpit of the gyrocopter is very limited for a bigger device like windows tablet PC. But it was not possible to connect the MTi-G device with the COM-object API namely xsensCMT.dll provided by the Xsens vendor in windows mobile platform. The connection in windows mobile platform could be made using the low level communication mentioned in the software development guide of Xsens MTi-G. But due to the lack of time that attempt could not be carried out. Therefore, preparing the application for windows mobile platform might be the future development of the application.








