using System;


class Vector3 {
	public int X;
	public int Y;
	public int Z;

	public void Vector3 (int x, int y, int z) {
		X = x;
		Y = y;
		Z = z;
	}
}

public static Vector3 operator + (Vector3 v1, Vector3 v2) {
	Vector3 v3 = new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
	return v3;
}

class Program {
	public static void Main (string[] args) {

	}
}