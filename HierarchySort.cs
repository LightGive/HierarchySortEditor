using UnityEngine;
using UnityEditor;
using System;

/// <summary>
/// 名前のアルファベット順でソートする
/// </summary>
public class NameSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return EditorUtility.NaturalCompare(lhs.name, rhs.name);
	}
}

/// <summary>
/// 座標のXの降順でソートする
/// </summary>
public class DesPositionXSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.y - lhs.transform.position.y) > 0 ? 1 : -1;
	}
}

/// <summary>
/// 座標のYの降順でソートする
/// </summary>
public class DesPositionYSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.y - lhs.transform.position.y) > 0 ? 1 : -1;
	}
}

/// <summary>
/// 座標のZの降順でソートする
/// </summary>
public class DesPositionZSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.z - lhs.transform.position.z) > 0 ? 1 : -1;
	}
}

/// <summary>
/// 座標のXの昇順でソートする
/// </summary>
public class AscPositionXSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.y - lhs.transform.position.y) > 0 ? -1 : 1;
	}
}

/// <summary>
/// 座標のYの昇順でソートする
/// </summary>
public class AscPositionYSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.y - lhs.transform.position.y) > 0 ? -1 : 1;
	}
}

/// <summary>
/// 座標のZの昇順でソートする
/// </summary>
public class AscPositionZSort : BaseHierarchySort
{
	public override int Compare(GameObject lhs, GameObject rhs)
	{
		if (lhs == rhs) return 0;
		if (lhs == null) return -1;
		if (rhs == null) return 1;

		return (rhs.transform.position.z - lhs.transform.position.z) > 0 ? -1 : 1;
	}
}

