// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroup_Info
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
  public class DataPointCollectionGroup_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_LastEnteredByRole")]
    protected Info _LastEnteredByRole;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_Points")]
    protected DataPointCollectionPoint_Info _Points;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_GroupLayout")]
    protected Info _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_MinimumSamples")]
    protected Info _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_LastEnteredOn")]
    protected Info _LastEnteredOn;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_LastEnteredOnGMT")]
    protected Info _LastEnteredOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Info_LastEnteredBy")]
    protected Info _LastEnteredBy;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public DataPointCollectionPoint_Info Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPoint_Info) this.PropertyGet(nameof (Points));
      }
    }

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

    public Info LastEnteredOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredOn));
      }
    }

    public Info LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredOnGMT));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
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

    public Info LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEnteredBy));
      }
    }
  }
}
