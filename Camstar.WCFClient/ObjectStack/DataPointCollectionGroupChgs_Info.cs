// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroupChgs_Info
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
  public class DataPointCollectionGroupChgs_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_GroupLayout")]
    protected Info _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_Points")]
    protected DataPointCollectionPointChgs_Info _Points;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_MinimumSamples")]
    protected Info _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Info_Name")]
    protected new Info _Name;

    public Info GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public DataPointCollectionPointChgs_Info Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPointChgs_Info) this.PropertyGet(nameof (Points));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinimumSamples));
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
  }
}
