﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispChanges_Info
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
  public class ActivityTmpltDispChanges_Info : ActivityTemplateChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_DispositionData")]
    protected DispositionDataChanges_Info _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_DisplayConformingQuantity")]
    protected Info _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_ReconcileQuantity")]
    protected Info _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Info_Name")]
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

    public DispositionDataChanges_Info DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (DispositionDataChanges_Info) this.PropertyGet(nameof (DispositionData));
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
