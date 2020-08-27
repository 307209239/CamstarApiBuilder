// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathSelector_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MovePathSelector_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReworkPathSelector_Info))]
  [Serializable]
  public class PathSelector_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_IsEnabled")]
    protected Info _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_Expression")]
    protected Info _Expression;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }

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

    public Info IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Info Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Expression));
      }
    }

    public Info EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Info EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info IsFrozen
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
  }
}
