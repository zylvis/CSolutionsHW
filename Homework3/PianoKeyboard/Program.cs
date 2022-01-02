using PianoKeyboard;

Key a = new Key(Note.A, Accidentall.Sharp, Octave.First);
Key b = new Key(Note.B, Accidentall.Flat, Octave.First);

Console.WriteLine(a);
Console.WriteLine(b);
Console.Write("IsEnharmonic: ");
Console.Write(a.Equals(b));
Console.WriteLine();
Console.WriteLine(a.CompareTo(b));
Console.WriteLine();