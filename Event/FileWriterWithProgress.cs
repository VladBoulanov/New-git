using System;

namespace Event
{
    public class FileWriterWithProgress
    {
        public delegate void WritingPerformed();
        public event WritingPerformed Count;
        public delegate void WritingCompleted();
        public event WritingCompleted OnCount;
        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {

            string text = Console.ReadLine();
            using (FileStream fstream = new FileStream(@"D:\note.dat", FileMode.OpenOrCreate))
            {
                data = Encoding.Default.GetBytes(text);
                fstream.Write(data, 0, data.Length);
                Percent = percentageToFireEvent;
                for (float i = 0; i < 1; i++)
                {
                    if (fstream.Write(data, 0, data.Length) % Percent = 0)
                    {
                        Count?.Invoke("Достигнут прогресс записи");
                    }
                    else if (i > 1)
                    {
                        OnCount?.Invoke("Достигнут конец записи");
                    }
                }
            }

        }
    }
}
