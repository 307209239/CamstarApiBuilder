// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollaboratorTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CollaboratorTemplateMaintService : NamedDataObjectMaintBase
  {
    public CollaboratorTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICollaboratorTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).Delete(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.Delete(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.Delete(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).Freeze(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.Freeze(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.Freeze(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.GetWIPMsgs(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).Load(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Load(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.Load(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus Load(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.Load(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_LoadESigDetails_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.LoadESigDetails, (CollaboratorTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_LoadESigDetails_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.LoadESigDetails(collaboratorTemplateMaint, (CollaboratorTemplateMaint_LoadESigDetails_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.LoadESigDetails(collaboratorTemplateMaint, (CollaboratorTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).New(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus New(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.New(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus New(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.New(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).NewCopy(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.NewCopy(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.NewCopy(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).SaveAs(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.SaveAs(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.SaveAs(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, collaboratorTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(collaboratorTemplateMaint, CollaboratorTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) collaboratorTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CollaboratorTemplateMaint) null, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint)
    {
      return this.UnFreeze(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.UnFreeze(collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_LoadESigDetails_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject collaboratorTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CollaboratorTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CollaboratorTemplateMaint) collaboratorTemplateMaint, (CollaboratorTemplateMaint_Parameters) parameters, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      try
      {
        CollaboratorTemplateMaintMethod[] methods = new CollaboratorTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICollaboratorTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollaboratorTemplateMaint cdo,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      try
      {
        return ((ICollaboratorTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CollaboratorTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CollaboratorTemplateMaint) cdo, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.GetEnvironment((CollaboratorTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CollaboratorTemplateMaint cdo,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      result = (CollaboratorTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICollaboratorTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(cdo, CollaboratorTemplateMaintMethods.ExecuteTransaction, (CollaboratorTemplateMaint_Parameters) null));
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
        CollaboratorTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CollaboratorTemplateMaint) cdo, (CollaboratorTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CollaboratorTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CollaboratorTemplateMaint_Request) null, out CollaboratorTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((CollaboratorTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CollaboratorTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CollaboratorTemplateMaintMethod(cdo, CollaboratorTemplateMaintMethods.AddDataTransaction, (CollaboratorTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((CollaboratorTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
