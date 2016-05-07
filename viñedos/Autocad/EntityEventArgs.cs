using System;
using WW.Cad.Model.Entities;

namespace vi�edos.Autocad {

    public class EntityEventArgs : EventArgs
    {
        private DxfEntity _entity;
        public EntityEventArgs(DxfEntity entity) {
            this._entity = entity;
        }
        public DxfEntity Entity {
            get {
                return _entity;
            }
        }
    }
}