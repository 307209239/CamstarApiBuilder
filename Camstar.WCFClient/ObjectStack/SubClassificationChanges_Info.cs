// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubClassificationChanges_Info
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
  public class SubClassificationChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Info_EventSubClassification")]
    protected Info _EventSubClassification;
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Info_Name")]
    protected new Info _Name;

    public Info EventSubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventSubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventSubClassification));
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
