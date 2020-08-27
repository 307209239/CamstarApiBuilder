// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepPassCount_Info
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
  public class StepPassCount_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_Info_StepPass")]
    protected Info _StepPass;

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
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

    public Info StepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepPass));
      }
    }
  }
}
