//Criando classe

class Elevator {

    // Construtor
    constructor() {

        // chamada dos métodos
        this.$elevator = $('.elevator');
        this.floorQtd = 3;
        this.isMovement = false;
        this.queue = [];
        this.initCamera();
        this.initEvents();
    }


    // Camera
    initCamera() {

        navigator.mediaDevices.getUserMedia({
            video: true
        }).then(stream => {

            var video = this.$elevator.find('.camera')[0];

            video.srcObject = stream;

        }).catch(err => {
            console.error(err);
        });

    }

    // Eventos
    initEvents() {

        // Cor do botão ao clicar
        $('.buttons .btn').on('click', e => {

            var btn = e.target;

            $(btn).addClass('floor-selected');

            var floor = $(btn).data('floor');

            this.goToFloor(floor);

        });

    }

    // Abre a porta
    openDoor() {

        return new Promise((resolve, reject) => {

            if (this.isDoorsOpen()) {

                this.transitionEnd(() => {
                    resolve();
                });

            } else {

                this.$elevator.find('.door').addClass('open');

                this.transitionEnd(() => {

                    resolve();
                });

            }

        });
    }

    // Fecha a porta
    closeDoor() {

        // promessa
        return new Promise((resolve, reject) => {


            if (this.isDoorsOpen()) {

                this.$elevator.find('.door').removeClass('open');

                setTimeout(() => {

                    resolve();

                }, 1800);

            } else {
                resolve();
            }
        });

    }

    // Verifica se estao abertas ou fechadas
    isDoorsOpen() {

        var doors = this.$elevator.find('.door');

        return ((doors.hasClass('open')));

    }

    transitionEnd(callback) {

        this.$elevator.on('webkitTransitionEnd otransitionend oTransitionEnd msTransitonEnd transitionend', () => {

            callback();
        })

    }

    // Mudar de andar
    goToFloor(number) {

        /*
            Promessas são as etapas
        */

        if (!this.isMovement) {

            this.isMovement = true;

            this.closeDoor().then(() => {

                new Promise((resolve, reject) => {

                    var currentFloor = this.$elevator.data('floor');

                    if (number !== currentFloor) {

                        this.removeFloorClass();

                        var diff = number - currentFloor;

                        var time = diff * 2;

                        this.$elevator.addClass(`floor${number}`);

                        this.$elevator.data('floor', number);

                        this.$elevator.css('-webkit-transition-duration', `${time}s`);

                        this.transitionEnd(() => {

                            resolve();

                        });
                    } else {
                        resolve();
                    }

                }).then(() => {

                    this.setDisplay(number);

                    this.openDoor().then(() => {

                        $(`.buttons .button${number}`).removeClass('floor-selected');

                        this.isMovement = false;

                        setTimeout(() => {

                            this.closeDoor();

                        }, 3000);

                        setTimeout(() => {

                            if (this.queue.length) {

                                var newFloor = this.queue.shift();

                                this.goToFloor(newFloor);

                            }

                        }, 2000);

                    });

                });
            });
        } else {

            this.queue.push(number);

        }

    }

    // Mudando Numero no display
    setDisplay(floor) {

        this.$elevator.find('.display').text(floor);

    }

    // remove as classes do andar
    removeFloorClass() {

        for (var i = 1; i <= this.floorQtd; i++) {

            this.$elevator.removeClass(`floor${i}`);

        }
    }

}