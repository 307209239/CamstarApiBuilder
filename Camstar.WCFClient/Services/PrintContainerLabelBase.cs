// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintContainerLabelBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class PrintContainerLabelBase : PrintLabelTxnBase, IPrintContainerLabelBase
  {
    protected virtual ResultStatus OnGetLabelInformation(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetLabelInformation");
    }

    ResultStatus IPrintContainerLabelBase.GetLabelInformation(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetLabelInformation(printContainerLabel, parameters, request, out result);
    }

    ResultStatus IPrintContainerLabelBase.GetLabelInformation()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIPrintContainerLabelBase\u002EGetLabelInformation((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IPrintContainerLabelBase.GetLabelInformation(
      DCObject printContainerLabel)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIPrintContainerLabelBase\u002EGetLabelInformation(printContainerLabel, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IPrintContainerLabelBase.GetLabelInformation(
      DCObject printContainerLabel,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIPrintContainerLabelBase\u002EGetLabelInformation(printContainerLabel, (Parameters) null, request, out result);
    }
  }
}
