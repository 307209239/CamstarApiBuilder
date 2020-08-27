// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IERPBOMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IERPBOMMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_LoadESigDetails_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ERPBOMMaintMethod[] methods,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result);
  }
}
