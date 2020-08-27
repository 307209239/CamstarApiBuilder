// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScaleStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScaleStatusCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_LoadESigDetails_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScaleStatusCodeMaintMethod[] methods,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result);
  }
}
