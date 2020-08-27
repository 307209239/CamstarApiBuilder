// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.CDODefinition
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator.ObjectModel
{
  internal class CDODefinition
  {
    private readonly ModelDataSet.CDOChildrenRow mRow;

    public CDODefinition(ModelDataSet.CDOChildrenRow row)
    {
      this.mRow = row;
    }

    public int CDOId
    {
      get
      {
        return this.mRow._WCFCDO_ID;
      }
    }

    public bool IsCountNull
    {
      get
      {
        return this.mRow.IsCountNull();
      }
    }

    public bool IsMethodNameNull
    {
      get
      {
        return this.mRow.IsMethodNameNull();
      }
    }

    public bool IsParameterNameNull
    {
      get
      {
        return this.mRow.IsParameterNameNull();
      }
    }

    public int CDOParentTypeID
    {
      get
      {
        return this.mRow.ParentID;
      }
    }

    public int Count
    {
      get
      {
        return this.mRow.Count;
      }
    }

    public string Description
    {
      get
      {
        return this.mRow.Description;
      }
    }

    public int Mask
    {
      get
      {
        return this.mRow.Mask;
      }
    }

    public string MethodDescription
    {
      get
      {
        return this.mRow.MethodDescription;
      }
    }

    public string MethodName
    {
      get
      {
        return this.mRow.MethodName;
      }
    }

    public string Name
    {
      get
      {
        return this.mRow.Name;
      }
    }

    public string ParameterName
    {
      get
      {
        return this.mRow.ParameterName;
      }
    }

    public string ParmeterDescription
    {
      get
      {
        return this.mRow.ParmeterDescription;
      }
    }
  }
}
