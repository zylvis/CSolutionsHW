using PianoKeyboard;
using PianoKeyboard.Utility;

Key a = new Key(Note.A, Accidentall.Sharp, Octave.First);
Console.WriteLine(a);

Key b = new Key(Note.B, Accidentall.Flat, Octave.First);

Console.WriteLine(b);


Console.Write("IsEnharmonic: ");
Console.Write(a.Equals(b));
Console.WriteLine();
