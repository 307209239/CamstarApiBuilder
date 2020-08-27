// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDiagramChgs_Info
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
  public class ResourceStatusDiagramChgs_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_ToStatusCodes")]
    protected Info _ToStatusCodes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_FromStatusCode")]
    protected Info _FromStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info ToStatusCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatusCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStatusCodes));
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

    public Info FromStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStatusCode));
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
