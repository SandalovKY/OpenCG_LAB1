# NNSU_OpenCG
## Отчет по лабораторной работе №1
## Сандалов Константин Юрьевич 381808-1
### Реализовано все, необходимое для нормального функционирования приложения : возможность выбрать исходный файл, выбрать нужный фильтр из перечисленных ниже, сохранить измененный файл(в формате jpg, png), отменить все произведенные действия, отменить выполнение применения фильтра к изображению, если успеете) просто немного ускорил работу программы за счет перехода от set/get pixel к представлению изображения, как массива битов, в котором пиксели следуют друг за другом(все строки выстраиваются последовательно, так же, друг за другом), и один пиксель занимает 4 бита - B, R, G, A. 
### Так же есть возможность изменять размер окна программы, и вместе с ним будет меняться и весь интерфейс, просто масштабироваться.
### 
![Blur](/examples/start.png)
![Blur](/examples/set.png)
## Matrix filters
### Source file
### 
### 
![Source](/examples/src/sh.png)
### 
### Blur filter
### 
![Blur](/examples/Blur_Sh.jpg)
### 
### Gaussian filter 
### 
![Gaussian](/examples/Gaussian_blur_Sh.jpg)
### 
### Median filter
### 
![Blur](/examples/Median_blur_Sh.jpg)
### 
### and comparsion with Gaussian blur
### 
### Source
### 
![src](/examples/src/prim.png)
### 
### Median blur
### Немного скругляет края(правда на этой картинке не очень заметно)
![Blur](/examples/Median_blur_Prim.jpg)
### 
### Gaussian
### 
![Blur](/examples/Gaussian_blur_Prim.jpg)
### 
### Embossing filter
### 
![Embossing](/examples/Embossing_Sh.jpg)
### 
### Max Sharpness filter
### 
![Blur](/examples/Max_shapness_Sh.jpg)
### 
### Пример фильтра светящиеся края
### Prewitt Filter
### 
![Blur](/examples/Prewitt_Sh.jpg)
### 
### Scharr filter
### 
![Blur](/examples/Scharr_Sh.jpg)
### 
### Sobel filter
### 
![Blur](/examples/Sobel_Sh.jpg)
### 
## Point filters
### 
### Glass filter
### 
![Glass](/examples/Glass_Sh.jpg)
### 
### GrayScale filter
### 
![GrayScale](/examples/Gray_scale_Sh.jpg)
### 
### GrayWorld filter
### 
![GrayWorld](/examples/Gray_world_Sh.jpg)
### 
### Source
![GrayWorld](/examples/src/4.PNG)
### 
### Result
![GrayWorld](/examples/Gray_world_Source.jpg)
### 
### Source
![GrayWorld](/examples/src/3.PNG)
### 
### Result
![GrayWorld](/examples/Gray_world_Source_2.jpg)
### 
### IdealReflector filter
### 
![Reflector](/examples/Ideal_reflector_Sh.jpg)
### 
### Inversion filter
### 
![Inversion](/examples/Inversoin_Sh.jpg)
### 
### Linear Extension
### 
![Inversion](/examples/Linear_extension_Sh.jpg)
### 
### Max Brightness filter
### 
![Inversion](/examples/Max_brightness_Sh.jpg)
### 
### Sepia filter
### 
![Inversion](/examples/Sepia_Sh.jpg)
### 
### Waves filter
### 
![Inversion](/examples/Waves_Sh.jpg)
### 
## Операции математической морфологии
### 
### Source
### 
![src](/examples/src/1.png)
### 
### Closing
### крест 3*3
![mm](/examples/mm/Closing_.jpg)
### квадрат 3*3
![mm](/examples/mm/Closing_full.jpg)
### диск 7*7
![mm](/examples/mm/Closing_ext.jpg)
### 
### Opening
### крест 3*3
![mm](/examples/mm/Opening_.jpg)
### квадрат 3*3
![mm](/examples/mm/Opening_full.jpg)
### диск 7*7 
![mm](/examples/mm/Opening_ext.jpg)
### 
### Dilation
### крест 3*3
![mm](/examples/mm/Dilation_.jpg)
### квадрат 3*3
![mm](/examples/mm/Dilation_full.jpg)
### диск 7*7
![mm](/examples/mm/Dilation_ext.jpg)
### 
### Erosion
### крест 3*3
![mm](/examples/mm/Erosion_.jpg)
### квадрат 3*3
![mm](/examples/mm/Erosion_full.jpg)
### диск 7*7
![mm](/examples/mm/Erosion_ext.jpg)
### 
### Grad
### 
### Source
![mm](/examples/src/cube.jpg)
### 
![mm](/examples/mm/crest.png)
### 
![mm](/examples/mm/full.png)
### 
![mm](/examples/mm/hor_line.png)
### 
![mm](/examples/mm/vert_line.png)
### 
### 
### 
![mm](/examples/mm/crest_ext.png)
### 
![mm](/examples/mm/ext.png)
### 
![mm](/examples/mm/hor_line_ext.png)
### 
![mm](/examples/mm/vert_line_ext.png)
