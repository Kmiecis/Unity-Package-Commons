using UnityEngine;

namespace Common
{
	public interface IMeshBuilder
	{
		void Overwrite(Mesh mesh);
		Mesh Build();
	}
}