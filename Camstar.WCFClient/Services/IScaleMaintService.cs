// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScaleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScaleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_LoadESigDetails_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScaleMaintMethod[] methods,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result);
  }
}
