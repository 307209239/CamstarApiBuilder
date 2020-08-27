// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureModeChanges_Info
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
  public class FailureModeChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Info_DefaultSeverity")]
    protected Info _DefaultSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Info_DefaultType")]
    protected Info _DefaultType;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Info_Name")]
    protected new Info _Name;

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

    public Info DefaultSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultSeverity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultSeverity));
      }
    }

    public Info DefaultType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultType));
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
