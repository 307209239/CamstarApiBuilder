// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetupChanges_Info
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
  public class SetupChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_StdSetupLaborTime")]
    protected Info _StdSetupLaborTime;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_StdSetupTime")]
    protected Info _StdSetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Info_Base")]
    protected new Info _Base;

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Info StdSetupLaborTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupLaborTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdSetupLaborTime));
      }
    }

    public Info StdSetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdSetupTime));
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

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
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
  }
}
