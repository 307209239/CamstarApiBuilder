// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateDisposition_Info
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
  public class ActivityTemplateDisposition_Info : ActivityTemplate_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Info_DisplayConformingQuantity")]
    protected Info _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Info_ReconcileQuantity")]
    protected Info _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Info_Name")]
    protected new Info _Name;

    public Info Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Disposition));
      }
    }

    public Info DisplayConformingQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayConformingQuantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayConformingQuantity));
      }
    }

    public Info ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReconcileQuantity));
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
