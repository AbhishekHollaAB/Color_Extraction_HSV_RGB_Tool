# Color Detection Using Slider

This is a **Windows Forms Application** built with **C#** and **OpenCvSharp** that allows you to:

- **Pick a color** from an image.
- **Generate a color** using RGB sliders.
- **Convert RGB to HSV** dynamically.
- **Apply a color range mask** on an image using **HSV sliders** to detect specific color regions.

---

## Features

- **Browse** and display an image.
- **Pick color** by clicking on the image.
- **Show BGR value** at the clicked point.
- **Manually adjust RGB sliders** to create colors.
- **Auto-convert RGB → HSV**.
- **Adjust HSV Range** using sliders to filter colors.
- **Live masking preview** based on HSV range.

---

## Built With

- **C#** (.NET Framework / .NET Core)
- **Windows Forms**
- **OpenCvSharp** (OpenCV wrapper for .NET)
- **System.Drawing**

---

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/ColorDetectionUsingSlider.git
   ```

2. Open the project in **Visual Studio**.

3. Make sure **OpenCvSharp4** and **OpenCvSharp4.Windows** NuGet packages are installed:
   - Right-click on Solution → Manage NuGet Packages → Search `OpenCvSharp4`

4. Build and run!

---

## Project Structure

- `Form1.cs` → Main UI logic
- `Form1.Designer.cs` → Windows Form Designer code
- `Program.cs` → Entry point

---

## Short Demo

- Browse an image.
- Click "Pick Color", click on the image → View BGR values.
- Move RGB sliders → See color updates.
- Adjust HSV Range sliders → View masked areas on the image matching the selected color.

---

## Notes

- Image resizing is handled for display only, but **color picking** is mapped to original image resolution.
- **Garbage collection** (`GC.Collect()`) is called manually after updates for performance.

---

## License

This project is open source under the [MIT License](LICENSE).

---

## Acknowledgements

- [OpenCvSharp](https://github.com/shimat/opencvsharp) for bridging OpenCV to C#.
- Windows Forms for easy UI building.

---

## Author

- [Abhishek Holla A B](https://github.com/AbhishekHollaAB)