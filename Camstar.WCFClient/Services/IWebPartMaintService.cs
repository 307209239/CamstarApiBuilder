// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWebPartMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWebPartMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_LoadESigDetails_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WebPartMaintMethod[] methods,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result);
  }
}
