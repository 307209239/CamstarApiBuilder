// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionDefChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DataPointCollectionDefChanges_Info : DataCollectionDefChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_Groups")]
    protected DataPointCollectionGroupChgs_Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_ParametricDataDefType")]
    protected new Info _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Info_Instructions")]
    protected Info _Instructions;

    public DataPointCollectionGroupChgs_Info Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroupChgs_Info) this.PropertyGet(nameof (Groups));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
