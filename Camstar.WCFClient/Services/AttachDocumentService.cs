// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AttachDocumentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AttachDocumentService : GenericTxnBase
  {
    public AttachDocumentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAttachDocumentService), userProfile);
    }

    public ResultStatus AttachDocument_CreateDoc(
      AttachDocument attachDocument,
      AttachDocument_AttachDocument_CreateDoc_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (AttachDocument_CreateDoc), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).AttachDocument_CreateDoc(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.AttachDocument_CreateDoc, (AttachDocument_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachDocument_CreateDoc), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachDocument_CreateDoc()
    {
      return this.AttachDocument_CreateDoc((AttachDocument) null, (AttachDocument_AttachDocument_CreateDoc_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_CreateDoc(AttachDocument attachDocument)
    {
      return this.AttachDocument_CreateDoc(attachDocument, (AttachDocument_AttachDocument_CreateDoc_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_CreateDoc(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.AttachDocument_CreateDoc(attachDocument, (AttachDocument_AttachDocument_CreateDoc_Parameters) null, request, out result);
    }

    public ResultStatus AttachDocument_GetObjectInstance(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (AttachDocument_GetObjectInstance), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).AttachDocument_GetObjectInstance(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.AttachDocument_GetObjectInstance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachDocument_GetObjectInstance), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachDocument_GetObjectInstance()
    {
      return this.AttachDocument_GetObjectInstance((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_GetObjectInstance(AttachDocument attachDocument)
    {
      return this.AttachDocument_GetObjectInstance(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_GetObjectInstance(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.AttachDocument_GetObjectInstance(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus AttachDocument_GetObjectType(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (AttachDocument_GetObjectType), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).AttachDocument_GetObjectType(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.AttachDocument_GetObjectType, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachDocument_GetObjectType), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachDocument_GetObjectType()
    {
      return this.AttachDocument_GetObjectType((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_GetObjectType(AttachDocument attachDocument)
    {
      return this.AttachDocument_GetObjectType(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_GetObjectType(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.AttachDocument_GetObjectType(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus AttachDocument_ValidateNotAlreadyAttached(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (AttachDocument_ValidateNotAlreadyAttached), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).AttachDocument_ValidateNotAlreadyAttached(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.AttachDocument_ValidateNotAlreadyAttached, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachDocument_ValidateNotAlreadyAttached), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachDocument_ValidateNotAlreadyAttached()
    {
      return this.AttachDocument_ValidateNotAlreadyAttached((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_ValidateNotAlreadyAttached(
      AttachDocument attachDocument)
    {
      return this.AttachDocument_ValidateNotAlreadyAttached(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_ValidateNotAlreadyAttached(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.AttachDocument_ValidateNotAlreadyAttached(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus AttachDocument_Validations(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (AttachDocument_Validations), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).AttachDocument_Validations(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.AttachDocument_Validations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachDocument_Validations), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachDocument_Validations()
    {
      return this.AttachDocument_Validations((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_Validations(AttachDocument attachDocument)
    {
      return this.AttachDocument_Validations(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus AttachDocument_Validations(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.AttachDocument_Validations(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).CreateParametricData(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus CreateParametricData(AttachDocument attachDocument)
    {
      return this.CreateParametricData(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus CreateParametricData(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.CreateParametricData(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).GetActions(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetActions(AttachDocument attachDocument)
    {
      return this.GetActions(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetActions(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.GetActions(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).GetDataPoints(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetDataPoints(AttachDocument attachDocument)
    {
      return this.GetDataPoints(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetDataPoints(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.GetDataPoints(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).GetWIPMsgs(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetWIPMsgs(AttachDocument attachDocument)
    {
      return this.GetWIPMsgs(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.GetWIPMsgs(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).Load(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus Load(AttachDocument attachDocument)
    {
      return this.Load(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus Load(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.Load(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AttachDocument attachDocument,
      AttachDocument_LoadESigDetails_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).LoadESigDetails(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.LoadESigDetails, (AttachDocument_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AttachDocument) null, (AttachDocument_LoadESigDetails_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus LoadESigDetails(AttachDocument attachDocument)
    {
      return this.LoadESigDetails(attachDocument, (AttachDocument_LoadESigDetails_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus LoadESigDetails(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.LoadESigDetails(attachDocument, (AttachDocument_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus MapLastActivityToContainer(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (MapLastActivityToContainer), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).MapLastActivityToContainer(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.MapLastActivityToContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (MapLastActivityToContainer), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus MapLastActivityToContainer()
    {
      return this.MapLastActivityToContainer((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus MapLastActivityToContainer(AttachDocument attachDocument)
    {
      return this.MapLastActivityToContainer(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus MapLastActivityToContainer(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.MapLastActivityToContainer(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).ProcessComputation(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus ProcessComputation(AttachDocument attachDocument)
    {
      return this.ProcessComputation(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus ProcessComputation(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.ProcessComputation(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) attachDocument, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).ResolveParametricData(this._UserProfile, attachDocument, parameters, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(attachDocument, AttachDocumentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) attachDocument, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AttachDocument) null, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus ResolveParametricData(AttachDocument attachDocument)
    {
      return this.ResolveParametricData(attachDocument, (AttachDocument_Parameters) null, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus ResolveParametricData(
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.ResolveParametricData(attachDocument, (AttachDocument_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus actions = this.GetActions((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AttachDocument) attachDocument, (AttachDocument_LoadESigDetails_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.Load((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject attachDocument,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AttachDocument) attachDocument, (AttachDocument_Parameters) parameters, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      try
      {
        AttachDocumentMethod[] methods = new AttachDocumentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAttachDocumentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AttachDocument cdo,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      try
      {
        return ((IAttachDocumentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus environment = this.GetEnvironment((AttachDocument) cdo, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.GetEnvironment((AttachDocument) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AttachDocument cdo,
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      result = (AttachDocument_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAttachDocumentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AttachDocumentMethod(cdo, AttachDocumentMethods.ExecuteTransaction, (AttachDocument_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AttachDocument_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AttachDocument) cdo, (AttachDocument_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AttachDocument cdo)
    {
      return this.ExecuteTransaction(cdo, (AttachDocument_Request) null, out AttachDocument_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AttachDocument_Request request,
      out AttachDocument_Result result)
    {
      return this.ExecuteTransaction((AttachDocument) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AttachDocument cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AttachDocumentMethod(cdo, AttachDocumentMethods.AddDataTransaction, (AttachDocument_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((AttachDocument) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
