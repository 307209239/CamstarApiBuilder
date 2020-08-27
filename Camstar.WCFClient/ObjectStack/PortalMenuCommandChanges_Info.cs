// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuCommandChanges_Info
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
  public class PortalMenuCommandChanges_Info : PortalMenuItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_QueryString")]
    protected Info _QueryString;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_PageURL")]
    protected Info _PageURL;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_PageDisplay")]
    protected Info _PageDisplay;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_StartPage")]
    protected Info _StartPage;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_VirtualPage")]
    protected Info _VirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_PageFlow")]
    protected Info _PageFlow;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Info_ServiceName")]
    protected Info _ServiceName;

    public Info QueryString
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryString), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryString));
      }
    }

    public Info PageURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PageURL));
      }
    }

    public Info PageDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageDisplay), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PageDisplay));
      }
    }

    public Info StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartPage));
      }
    }

    public Info VirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VirtualPage));
      }
    }

    public Info PageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PageFlow));
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

    public Info ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
