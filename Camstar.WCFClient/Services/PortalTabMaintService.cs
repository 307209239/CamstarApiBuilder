// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PortalTabMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PortalTabMaintService : NamedDataObjectMaintBase
  {
    public PortalTabMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPortalTabMaintService), userProfile);
    }

    public ResultStatus Delete(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).Delete(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Delete(PortalTabMaint portalTabMaint)
    {
      return this.Delete(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Delete(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.Delete(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).Freeze(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Freeze(PortalTabMaint portalTabMaint)
    {
      return this.Freeze(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Freeze(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.Freeze(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).GetWIPMsgs(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PortalTabMaint portalTabMaint)
    {
      return this.GetWIPMsgs(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.GetWIPMsgs(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).Load(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Load(PortalTabMaint portalTabMaint)
    {
      return this.Load(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus Load(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.Load(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_LoadESigDetails_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).LoadESigDetails(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.LoadESigDetails, (PortalTabMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PortalTabMaint) null, (PortalTabMaint_LoadESigDetails_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PortalTabMaint portalTabMaint)
    {
      return this.LoadESigDetails(portalTabMaint, (PortalTabMaint_LoadESigDetails_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.LoadESigDetails(portalTabMaint, (PortalTabMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).New(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus New(PortalTabMaint portalTabMaint)
    {
      return this.New(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus New(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.New(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).NewCopy(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus NewCopy(PortalTabMaint portalTabMaint)
    {
      return this.NewCopy(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus NewCopy(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.NewCopy(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).SaveAs(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus SaveAs(PortalTabMaint portalTabMaint)
    {
      return this.SaveAs(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus SaveAs(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.SaveAs(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) portalTabMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).UnFreeze(this._UserProfile, portalTabMaint, parameters, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(portalTabMaint, PortalTabMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) portalTabMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PortalTabMaint) null, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus UnFreeze(PortalTabMaint portalTabMaint)
    {
      return this.UnFreeze(portalTabMaint, (PortalTabMaint_Parameters) null, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.UnFreeze(portalTabMaint, (PortalTabMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PortalTabMaint) portalTabMaint, (PortalTabMaint_LoadESigDetails_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.New((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.Load((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject portalTabMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalTabMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PortalTabMaint) portalTabMaint, (PortalTabMaint_Parameters) parameters, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      try
      {
        PortalTabMaintMethod[] methods = new PortalTabMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPortalTabMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalTabMaint cdo,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      try
      {
        return ((IPortalTabMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PortalTabMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PortalTabMaint) cdo, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.GetEnvironment((PortalTabMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PortalTabMaint cdo,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      result = (PortalTabMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalTabMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PortalTabMaintMethod(cdo, PortalTabMaintMethods.ExecuteTransaction, (PortalTabMaint_Parameters) null));
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
        PortalTabMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PortalTabMaint) cdo, (PortalTabMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PortalTabMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PortalTabMaint_Request) null, out PortalTabMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result)
    {
      return this.ExecuteTransaction((PortalTabMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PortalTabMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PortalTabMaintMethod(cdo, PortalTabMaintMethods.AddDataTransaction, (PortalTabMaint_Parameters) null));
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
        return this.AddDataTransaction((PortalTabMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
