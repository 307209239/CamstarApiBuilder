// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAddSPCAnnotationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAddSPCAnnotationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_LoadESigDetails_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AddSPCAnnotationMethod[] methods,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result);
  }
}
